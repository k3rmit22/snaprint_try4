using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PdfiumViewer;



namespace snaprint_try4
{
    public partial class preferences : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=admin_user;Uid=root;Pwd=;");
        private string selectedFileName;
        private string selectedFilePath;
        private byte[] pdfData;


        private double selectedPrice = 0;

        public preferences()

        {
        }

        public preferences(string selectedFileName, string selectedFilePath, byte[] pdfData)
        {
            InitializeComponent();
            InitializeKioskMode();
            SetDoubleBuffered();

            PopulateCopyComboBox();


            // Set the selected file name
            this.selectedFileName = selectedFileName;

            // Display the selected file name in the filename TextBox
            filename.Text = selectedFilePath;
            this.selectedFileName = selectedFileName;
            this.pdfData = pdfData;
        }

        //diplaying in combobox
     
        public class PriceColorItem
        {
            public double Price { get; set; }
            public string Color { get; set; }

            public override string ToString()
            {
                return $"Price: {Price}, Color: {Color}";
            }
        }

        //getting data from mqsl

        void myprice()
        {
            string command_query = "SELECT AdjustedPrice, Color FROM tbl_pricing";
            MySqlCommand cmd = new MySqlCommand(command_query, conn);
            MySqlDataReader mydr;
            try
            {
                conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    double price = mydr.GetDouble("AdjustedPrice");
                    string color = mydr.GetString("Color");

                    // Create a new PriceColorItem instance
                    PriceColorItem item = new PriceColorItem
                    {
                        Price = price,
                        Color = color
                    };

                    // Add the item to the combo box
                    combocolor.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close(); // Close the connection in the finally block to ensure it's always closed
            }
        }

        // displaying mqsl data
        private void preferences_Load(object sender, EventArgs e)
        {
            myprice();
        }

        // get data 
        public preferences(string selectedFileName, byte[] pdfData)
        {
            this.selectedFileName = selectedFileName;
            this.pdfData = pdfData;
        }

        // double buffer forms and avoid flickering
        private void SetDoubleBuffered()
        {
            this.DoubleBuffered = true;
        }

        // koiskmode
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

        
      


        //back button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            file_explorer prev = new file_explorer();
            prev.Show();
            this.Hide();
        }

        // fir flickering forms

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }

        //view pdf code

        private void pdfViewer1_Load(object sender, EventArgs e)
        {
            LoadPdfIntoViewer((byte[])pdfData);
        }

        private void LoadPdfIntoViewer(byte[] pdfData)
        {
            try
            {
                using (MemoryStream stream = new MemoryStream(pdfData))
                {
                    // Load the PDF document without disposing it immediately
                    PdfDocument pdfDocument = PdfDocument.Load(stream);

                    // Assign the PDF document to the PdfViewer
                    pdfViewer1.Document = pdfDocument;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // get pdf docu number of pages
        private int GetNumberOfPages(byte[] pdfData)
        {
            try
            {
                using (MemoryStream stream = new MemoryStream(pdfData))
                {
                    // Load the PDF document without disposing it immediately
                    PdfDocument pdfDocument = PdfDocument.Load(stream);

                    // Get the number of pages in the PDF document
                    int numberOfPages = pdfDocument.PageCount;

                    // Display the number of pages in the console
                    Console.WriteLine($"Number of pages in the PDF: {numberOfPages}");

                    // Return the number of pages in the PDF document
                    return numberOfPages;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur while loading the PDF
                MessageBox.Show($"An error occurred while loading the PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; // Return 0 if an error occurs
            }
        }

        //hard coded to populate combobox for copies
        private void PopulateCopyComboBox()
        {
            // Clear the existing items in the combocopies ComboBox
            combocopies.Items.Clear();

            // Add the values 1, 2, 3, 4, and 5 to the combocopies ComboBox
            for (int i = 1; i <= 5; i++)
            {
                combocopies.Items.Add(i);
            }

            // Set the default selected item to the first item (1)
            combocopies.SelectedIndex = 0;
        }



        private void combocolor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Check if an item is selected in the combocolor combo box
                if (combocolor.SelectedItem != null)
                {
                    // Cast the selected item to PriceColorItem and capture the price
                    selectedPrice = ((PriceColorItem)combocolor.SelectedItem)?.Price ?? 0;
                    if (selectedPrice == 0)
                    {
                        MessageBox.Show("Selected item does not have a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving the selected price: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        // Method to compute the total price
        // Method to compute the total price

        private double ComputeTotalPrice(double pricePerColor, string copies, byte[] pdfData)
        {
            try
            {
                // Check if the selected price is valid
                if (pricePerColor <= 0)
                {
                    MessageBox.Show("Please select a valid price for the color.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }

                // Retrieve the number of pages in the PDF document
                int totalPages = GetNumberOfPages(pdfData);

                // Retrieve the number of copies selected by the user
                int numberOfCopies = int.Parse(copies);

                // Calculate the total price
                double totalPrice = pricePerColor * totalPages * numberOfCopies;

                return totalPrice;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while computing the total price: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; // Return 0 if an error occurs
            }
        }




        /*private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Check if all combo boxes have a selected item
            if (combosize.SelectedItem != null && combocopies.SelectedItem != null && combocolor.SelectedItem != null && pdfData != null && pdfData.Length > 0)
            {
                // Get user selections
                string paperSize = combosize.SelectedItem.ToString();
                string copies = combocopies.SelectedItem.ToString();
                string color = combocolor.SelectedItem.ToString();
                string selectedFileName = filename.Text; // Assuming filename is the name of the textbox
                int numberOfPages = GetNumberOfPages(pdfData);

                double pricePerColor = ((PriceColorItem)combocolor.SelectedItem)?.Price ?? 0;

                double totalPrice = ComputeTotalPrice(pricePerColor, copies, pdfData);




                // Print debug messages
                Console.WriteLine("Selected PDF file received successfully:");
                Console.WriteLine($"  File Name: {selectedFileName}");
                Console.WriteLine($"  Paper Size: {paperSize}");
                Console.WriteLine($"  Copies: {copies}");
                Console.WriteLine($"  Color: {color}");
                Console.WriteLine($"  Number of pages in the PDF: {numberOfPages}");

              


                // Proceed to the next step or form
                // Example: navigate to the next form
                Form nextForm = new summary(selectedFileName, copies, color, paperSize, pdfData, totalPrice); // Pass the pdfData to the summary form
                nextForm.Show();
                this.Hide();
            }
            else
            {
                // Display a message indicating that all selections are required
                MessageBox.Show("Please select options for all fields and make sure a PDF file is loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Check if all combo boxes have a selected item
            if (combosize.SelectedItem != null && combocopies.SelectedItem != null && combocolor.SelectedItem != null && pdfData != null && pdfData.Length > 0)
            {
                // Get user selections
                string paperSize = combosize.SelectedItem.ToString();
                string copies = combocopies.SelectedItem.ToString();
                string selectedFileName = filename.Text; // Assuming filename is the name of the textbox

                // Get the selected PriceColorItem from the combocolor
                PriceColorItem selectedPriceColorItem = combocolor.SelectedItem as PriceColorItem;
                if (selectedPriceColorItem == null)
                {
                    MessageBox.Show("Please select a color.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get the price per color from the selected PriceColorItem
                double pricePerColor = selectedPriceColorItem.Price;

                // Calculate total price
                double totalPrice = ComputeTotalPrice(pricePerColor, copies, pdfData);

                // Print debug messages
                Console.WriteLine("Selected PDF file received successfully:");
                Console.WriteLine($"  File Name: {selectedFileName}");
                Console.WriteLine($"  Paper Size: {paperSize}");
                Console.WriteLine($"  Copies: {copies}");
                Console.WriteLine($"  Color: {selectedPriceColorItem.Color}");
                Console.WriteLine($"  Number of pages in the PDF: {GetNumberOfPages(pdfData)}");
                Console.WriteLine($"  Total Price: {totalPrice}");

                // Proceed to the next step or form
                Form nextForm = new summary(selectedFileName, copies, selectedPriceColorItem.Color, paperSize, pdfData, totalPrice);
                nextForm.Show();
                this.Hide();
            }
            else
            {
                // Display a message indicating that all selections are required
                MessageBox.Show("Please select options for all fields and make sure a PDF file is loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





    }


}

