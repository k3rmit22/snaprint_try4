using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Drawing;
using PdfiumViewer;
using System.Printing;
using System.Drawing.Printing;
using System.Management;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.IO.Ports;
using System.Linq;




namespace snaprint_try4
{
    public partial class summary : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=admin_user;Uid=root;Pwd=;");
        private string printingOption;
        private string selectedFileName;
        private string selectedFilepath; //display file

        private string selectedCopies;
        private string selectedColor;
        private string selectedPaperSize;
        private byte[] pdfData; // Store the PDF file data here
        //private string selectedFilePath;
        


        private double totalPrice;

        private double balance = 0; // Variable to store the balance

       


        SerialPort serialPort = new SerialPort();

        public summary(string selectedFileName, string selectedFilepath, string copies, string color, string selectedPaperSize, byte[] pdfData, double totalPrice, string printingOption)
        {
            InitializeComponent();
            InitializeKioskMode();
            SetDoubleBufferred();

            //  CheckPrinterStatus();

            serialPort.PortName = "COM8"; // Change the port name to match the Arduino's port
            serialPort.BaudRate = 9600; // Set the baud rate to match the Arduino's baud rate
            serialPort.DataReceived += SerialPort_DataReceived; // Subscribe to DataReceived event
            serialPort.Open();

            // Send the total price to the Arduino
            //SendTotalPriceToESP32(totalPrice);

            this.selectedFileName = selectedFileName;
            this.selectedCopies = copies;
            this.selectedColor = color;
            this.selectedPaperSize = selectedPaperSize;
            this.selectedFilepath = selectedFilepath; // Assign parameter value to the field
            this.totalPrice = totalPrice;
            this.printingOption = printingOption;
          //  this.selectedPrinter = selectedPrinter; // get selected printer
            


            // Display selected items in labels

            labelCopies.Text = copies;
            labelColor.Text = color;
            labelPaperSize.Text = selectedPaperSize;
            filename.Text = selectedFilepath;
            lblTotalPrice.Text = $"Total Price: ₱{totalPrice:N2}";

            // Store the PDF file data
            this.pdfData = pdfData;
            // PrintPdf(); ibalik mamaya 

            SendTotalPriceToESP32(totalPrice);
        }

        private void summary_Load(object sender, EventArgs e)
        {
            SendTotalPriceToESP32(totalPrice);
            serialPort.DiscardInBuffer();

        }


        private void SendTotalPriceToESP32(double totalPrice)
        {
            try
            {
                // Convert the double value to a string
                string totalPriceStr = totalPrice.ToString();

                // Send the string over the serial port to the ESP32
                serialPort.WriteLine(totalPriceStr);

                // Print a console message indicating that the total price is sent
                Console.WriteLine("Sent total price to ESP32: " + totalPrice);

                // Check if total price is sent successfully
                if (serialPort.BytesToWrite == 0)
                {
                    // Debugging message
                    Console.WriteLine("Total price sent successfully.");
                }
                else
                {
                    // Debugging message
                    Console.WriteLine("Failed to send total price.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending total price to ESP32: " + ex.Message);
            }
        }



        /*private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // Read data from the serial port
                string receivedDataStr = serialPort.ReadLine(); // Read the data as a string

                // Display the received string in the console
                Console.WriteLine("Received data from ESP32: " + receivedDataStr);

                // Convert the string to a double
                if (double.TryParse(receivedDataStr, out double balance))
                {
                    // Update the balance display
                    UpdateBalance(receivedDataStr);

                    // Print a message indicating successful conversion
                    Console.WriteLine("Successfully converted balance data to double: " + balance);
                    if (balance >= totalPrice)
                    {
                        try
                        {
                            // Reset the balance
                            balance = 0;
                            Console.WriteLine("Balance reset to zero.");
                            UpdateBalance("Payment success!!");
                            //UpdateBalance("0.00"); // Update UI with zero balance

                            // Discard any remaining data in the serial port's input buffer
                            serialPort.DiscardInBuffer();

                            SelectPrinterBasedOnPaperSize();
                            // Print the document
                            try
                            {
                                // Convert the selected copies to an integer
                                int numberOfCopies = int.Parse(selectedCopies);

                                // Loop to print multiple copies
                                for (int i = 0; i < numberOfCopies; i++)
                                {
                                    using (MemoryStream memoryStream = new MemoryStream(pdfData))
                                    {
                                        using (PdfDocument pdfDocument = PdfDocument.Load(memoryStream))
                                        {
                                            using (PrintDocument printDocument = pdfDocument.CreatePrintDocument())
                                            {
                                                // Apply printer settings based on the preferred printing option
                                                if (printingOption.Equals("Black", StringComparison.OrdinalIgnoreCase))
                                                {
                                                    SetPrinterSettingsToGreyscale(printDocument);
                                                }
                                                else if (printingOption.Equals("Colored", StringComparison.OrdinalIgnoreCase))
                                                {
                                                    SetPrinterSettingsToColored(printDocument);
                                                }

                                                // Print the document
                                                
                                                printDocument.Print();
                                            }
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"An error occurred while printing the PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error: Unable to parse balance data.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading balance data from ESP32: " + ex.Message);
            }
        }
        */

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // Read data from the serial port
                string receivedDataStr = serialPort.ReadLine(); // Read the data as a string

                // Display the received string in the console
                Console.WriteLine("Received data from ESP32: " + receivedDataStr);
                // Send the balance to the SQL database
               

                // Convert the string to a double
                if (double.TryParse(receivedDataStr, out double balance))
                {
                    // Update the balance display
                    UpdateBalance(receivedDataStr);

                    // Print a message indicating successful conversion
                    Console.WriteLine("Successfully converted balance data to double: " + balance);
                    if (balance >= totalPrice)
                    {
                        try
                        {
                            // Reset the balance
                            //balance = 0;
                            //Console.WriteLine("Balance reset to zero.");
                            //UpdateBalance("Payment success!!");
                            //UpdateBalance("0.00"); // Update UI with zero balance
                            
                            // Send the balance to the SQL database
                            UpdateBalanceInDatabase(balance); 
                            
                            // Discard any remaining data in the serial port's input buffer
                            // serialPort.DiscardInBuffer();

                            // Call the method to print the document
                            try
                            {
                               
                                PrintDocument();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"An error occurred while printing the document: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error: Unable to parse balance data.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading balance data from ESP32: " + ex.Message);
            }
        }

        //code for printing the docu
        /*
                private void PrintDocument()
                {
                    try
                    {
                        // Convert the selected copies to an integer
                        int numberOfCopies = int.Parse(selectedCopies);

                        string selectedPrinter = GetPrinterBasedOnPaperSize();

                        // Loop to print multiple copies
                        for (int i = 0; i < numberOfCopies; i++)
                        {
                            using (MemoryStream memoryStream = new MemoryStream(pdfData))
                            {
                                using (PdfDocument pdfDocument = PdfDocument.Load(memoryStream))
                                {
                                    using (PrintDocument printDocument = pdfDocument.CreatePrintDocument())
                                    {
                                        // Apply printer settings based on the preferred printing option
                                        if (printingOption.Equals("Black", StringComparison.OrdinalIgnoreCase))
                                        {
                                            SetPrinterSettingsToGreyscale(printDocument);
                                        }
                                        else if (printingOption.Equals("Colored", StringComparison.OrdinalIgnoreCase))
                                        {
                                            SetPrinterSettingsToColored(printDocument);
                                        }

                                        // Print the document
                                        printDocument.Print();
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while printing the PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        */

        //code for sending balance to database 
        
        private void UpdateBalanceInDatabase(double balance)
        {
            // Database connection parameters
            string connectionString = "Server=localhost;Port=3306;Database=admin_user;Uid=root;Pwd=;";

            // SQL command to update the balance in the database
            string updateCommandText = "UPDATE tbl_income SET inserted_amount = @balance WHERE Id = @id";

            // Example Id
            int latestId;

            // Create and open connection
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Get the latest ID from the database
                string getMaxIdQuery = "SELECT MAX(Id) FROM tbl_income";
                using (MySqlCommand getMaxIdCommand = new MySqlCommand(getMaxIdQuery, connection))
                {
                    latestId = Convert.ToInt32(getMaxIdCommand.ExecuteScalar());
                }

                // Create command
                using (MySqlCommand command = new MySqlCommand(updateCommandText, connection))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@balance", balance);
                    command.Parameters.AddWithValue("@id", latestId);

                    // Execute command
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if rows were affected
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Balance updated successfully in the database.");
                    }
                    else
                    {
                        Console.WriteLine("No rows updated in the database.");
                    }
                }
            }
        }
        

        private void PrintDocument()
        {
            try
            {
                // Convert the selected copies to an integer
                int numberOfCopies = int.Parse(selectedCopies);

                // Initialize the printer name variable
                string selectedPrinter = "";

                // Check the selected paper size
                if (selectedPaperSize == "Long")
                {
                    // If the selected paper size is "Long", set the printer name to the Brother printer
                    selectedPrinter = "Brother DCP-T420W Printer";
                }
                else if (selectedPaperSize == "Short")
                {
                    // If the selected paper size is "Short", set the printer name to the Canon printer
                    selectedPrinter = "Canon E470 series";
                }
                else
                {
                    // Handle any other cases or set a default printer name
                    selectedPrinter = "Default Printer";
                }

                // Loop to print multiple copies
                for (int i = 0; i < numberOfCopies; i++)
                {
                    using (MemoryStream memoryStream = new MemoryStream(pdfData))
                    {
                        using (PdfDocument pdfDocument = PdfDocument.Load(memoryStream))
                        {
                            using (PrintDocument printDocument = pdfDocument.CreatePrintDocument())
                            {
                                // Set the selected printer for printing
                                printDocument.PrinterSettings.PrinterName = selectedPrinter;

                                // Apply printer settings based on the preferred printing option
                                if (printingOption.Equals("Black", StringComparison.OrdinalIgnoreCase))
                                {
                                    SetPrinterSettingsToGreyscale(printDocument);
                                }
                                else if (printingOption.Equals("Colored", StringComparison.OrdinalIgnoreCase))
                                {
                                    SetPrinterSettingsToColored(printDocument);
                                }

                                // Print the document
                                printDocument.Print();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while printing the PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        /*
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // Read data from the serial port
                string receivedDataStr = serialPort.ReadLine(); // Read the data as a string

                // Display the received string in the console
                Console.WriteLine("Received data from ESP32: " + receivedDataStr);

                // Convert the string to a double
                if (double.TryParse(receivedDataStr, out double balance))
                {
                    // Update the balance display
                    UpdateBalance(receivedDataStr);

                    // Print a message indicating successful conversion
                    Console.WriteLine("Successfully converted balance data to double: " + balance);
                    if (balance >= totalPrice)
                    {
                        // Reset the balance
                        balance = 0;
                        Console.WriteLine("Balance reset to zero.");
                        UpdateBalance("Payment success!!");
                        serialPort.DiscardInBuffer();

                        // Print the document
                        PrintDocument();
                    }
                }
                else
                {
                    Console.WriteLine("Error: Unable to parse balance data.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading balance data from ESP32: " + ex.Message);
            }
        }
        
        private void PrintDocument()
        {
            try
            {
                // Convert the selected copies to an integer
                int numberOfCopies = int.Parse(selectedCopies);

                // Loop to print multiple copies
                for (int i = 0; i < numberOfCopies; i++)
                {
                    using (MemoryStream memoryStream = new MemoryStream(pdfData))
                    using (PdfDocument pdfDocument = PdfDocument.Load(memoryStream))
                    using (PrintDocument printDocument = pdfDocument.CreatePrintDocument())
                    {
                        // Apply printer settings based on the preferred printing option
                        if (printingOption.Equals("Black", StringComparison.OrdinalIgnoreCase))
                        {
                            SetPrinterSettingsToGreyscale(printDocument);
                        }
                        else if (printingOption.Equals("Colored", StringComparison.OrdinalIgnoreCase))
                        {
                            SetPrinterSettingsToColored(printDocument);
                        }

                        // Print the document
                        printDocument.Print();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while printing the PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */


        private void UpdateBalance(string balanceStr)
       {
       // Update the text of lblamount_ins label with the received balance
       label1.Invoke((MethodInvoker)(() => label1.Text = balanceStr));
       }
  




        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (serialPort.IsOpen)
            {
                serialPort.Close(); // Close the serial port if it's open
            }
        }




        private void SetDoubleBufferred()
        {
            this.DoubleBuffered = true;
        }




        //kiosk mode
        private void InitializeKioskMode()
        {
            // Set the form to cover the entire screen
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            // Disable Alt+F4 to prevent closing the application
            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (e.Alt && e.KeyCode == Keys.F4)
                    e.Handled = true;
            };
        }




        private void button2_Click(object sender, EventArgs e)
        {
            // Check if the balance is greater than or equal to the total price
            
                browse next = new browse();
                next.Show();

                // Close the summary form
                this.Close();
            
          
        }



        private void SetPrinterSettingsToGreyscale(PrintDocument printDocument)
        {
            // Modify the printer settings to greyscale
            printDocument.DefaultPageSettings.Color = false; // Set to greyscale
        }

        private void SetPrinterSettingsToColored(PrintDocument printDocument)
        {
            // Modify the printer settings to colored
            printDocument.DefaultPageSettings.Color = true; // Set to colored
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                using (MemoryStream stream = new MemoryStream(pdfData))
                {
                    using (var image = Image.FromStream(stream))
                    {
                        // Draw the image on the print page
                        e.Graphics.DrawImage(image, e.MarginBounds);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while printing the PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            preferences back = new preferences(selectedFileName, selectedFilepath, pdfData);
            back.Show();
            this.Close();
        }

      


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }



        private void ReportIssueButton_Click(object sender, EventArgs e)
        {
            // Show the report dialog
            using (ReportDialog dialog = new ReportDialog())
            {
                // Display the dialog box
                dialog.ShowDialog();

                // After the dialog is closed, you can access the report text from dialog.textBox.Text
                string report = dialog.textBox.Text;

                // You can then process the report text as needed
                if (!string.IsNullOrEmpty(report))
                {
                    // Here you can send the report to your database or perform any other necessary action
                    MessageBox.Show("Report submitted successfully: " + report, "Report Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No report submitted.", "No Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ReportIssueButton_Click_1(object sender, EventArgs e)
        {
            // Show the report dialog
            using (ReportDialog dialog = new ReportDialog())
            {
                // Display the dialog box
                dialog.ShowDialog();

                // After the dialog is closed, you can access the report text from dialog.textBox.Text
                string report = dialog.textBox.Text;

                // You can then process the report text as needed
                if (!string.IsNullOrEmpty(report))
                {
                    // Here you can send the report to your database or perform any other necessary action
                    MessageBox.Show("Report submitted successfully: " + report, "Report Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No report submitted.", "No Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }
    }








}

