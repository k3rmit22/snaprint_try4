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




namespace snaprint_try4
{
    public partial class summary : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=admin_user;Uid=root;Pwd=;");
        private string printingOption;
        private string selectedFileName; //display file

        private string selectedCopies;
        private string selectedColor;
        private string selectedPaperSize;
        private byte[] pdfData; // Store the PDF file data here
        private string selectedFilePath;


        private double totalPrice;

        private double balance = 0; // Variable to store the balance

       


        SerialPort serialPort = new SerialPort();

        public summary(string selectedFileName, string copies, string color, string paperSize, byte[] pdfData, double totalPrice, string printingOption)
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


            this.selectedCopies = copies;
            this.selectedColor = color;
            this.selectedPaperSize = paperSize;
            this.selectedFileName = selectedFileName; // Assign parameter value to the field
            this.totalPrice = totalPrice;
            this.printingOption = printingOption;

            // Display selected items in labels

            labelCopies.Text = copies;
            labelColor.Text = color;
            labelPaperSize.Text = paperSize;
            filename.Text = selectedFileName;
            lblTotalPrice.Text = $"Total Price: ₱{totalPrice:N2}";

            // Store the PDF file data
            this.pdfData = pdfData;
            // PrintPdf(); ibalik mamaya 

            SendTotalPriceToESP32(totalPrice);
        }

        private void summary_Load(object sender, EventArgs e)
        {
            SendTotalPriceToESP32(totalPrice);
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



        /*
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // Read data from the serial port
                string receivedDataStr = serialPort.ReadLine(); // Read the data as a string
                double receivedData = double.Parse(receivedDataStr); // Convert the string to a double

                // Store the received data as the balance
                balance = (int)receivedData;
                Console.WriteLine("Received balance: " + balance);

                // Update the balance display
                UpdateBalance(balance);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading balance data from ESP32: " + ex.Message);
            }
        } */


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
                        try
                        {
                            // CheckPrinterStatus();

                            if (!ValidatePdfData(pdfData))
                            {
                                // Validation failed, return without printing
                                return;
                            }

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

                            // Show the loading form after printing
                            loading next = new loading();
                            next.Show();

                            // Close the summary form
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred while printing the PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


       
       
       private void UpdateBalance(string balanceStr)
       {
       // Update the text of lblamount_ins label with the received balance
       label1.Invoke((MethodInvoker)(() => label1.Text = balanceStr));
       }
  




      //  private void UpdateBalance(double balance)
     //   {
            // Update the text of lblamount_ins label with the received balance
      //      label1.Invoke((MethodInvoker)(() => label1.Text = balance.ToString()));
     //   }



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




        /*
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidatePdfData(pdfData))
                {
                    // Validation failed, return without printing
                    return;
                }

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
                            else if (printingOption.Equals("Colored", StringComparison.OrdinalIgnoreCase)) // inadd yung Colored kagabi wala pero working 
                            {
                                SetPrinterSettingsToColored(printDocument);
                            }


                            printDocument.Print();
                           
                            loading next = new loading();
                            next.Show();

                           
                            this.Close();


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while printing the PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } */ // button printing without copies 

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               // CheckPrinterStatus();

                if (!ValidatePdfData(pdfData))
                {
                    // Validation failed, return without printing
                    return;
                }

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

                // Show the loading form after printing
                loading next = new loading();
                next.Show();

                // Close the summary form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while printing the PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            preferences back = new preferences(selectedFileName, selectedFilePath, pdfData);
            back.Show();
            this.Close();
        }


        private bool ValidatePdfData(byte[] pdfData)
        {
            // Check for null or empty data
            if (pdfData == null || pdfData.Length == 0)
            {
                MessageBox.Show("PDF data is empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check for PDF file signature ("%PDF-")
            if (!IsPdfFile(pdfData))
            {
                MessageBox.Show("Invalid PDF file format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            MessageBox.Show("PDF data is valid.", "Validation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        private bool IsPdfFile(byte[] data)
        {
            // Check if the first few bytes match the PDF file signature ("%PDF-")
            if (data.Length >= 5 &&
                data[0] == 0x25 &&  // '%'
                data[1] == 0x50 &&  // 'P'
                data[2] == 0x44 &&  // 'D'
                data[3] == 0x46 &&  // 'F'
                data[4] == 0x2D)    // '-'
            {
                return true;
            }
            return false;
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
    }




}

