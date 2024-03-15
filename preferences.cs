using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace snaprint_try4
{
    public partial class preferences : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=admin_user;Uid=root;Pwd=;");
        private string selectedFileName;
        private string selectedFilePath;
        private byte[] pdfData;
        public preferences()
        {
        }

        public preferences(string selectedFileName, string selectedFilePath, byte[] pdfData)
        {
            InitializeComponent();
            InitializeKioskMode();
            SetDoubleBuffered();

            // Set the selected file name
            this.selectedFileName = selectedFileName;

            // Display the selected file name in the filename TextBox
            filename.Text = selectedFilePath;
            this.selectedFileName = selectedFileName;
            this.pdfData = pdfData;
        }

        public class PriceColorItem
        {
            public double Price { get; set; }
            public string Color { get; set; }

            public override string ToString()
            {
                return $"Price: {Price}, Color: {Color}";
            }
        }

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


        private void preferences_Load(object sender, EventArgs e)
        {
            myprice();
        }


        public preferences(string selectedFileName, byte[] pdfData)
        {
            this.selectedFileName = selectedFileName;
            this.pdfData = pdfData;
        }

        private void SetDoubleBuffered()
        {
            this.DoubleBuffered = true;
        }

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
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Check if all combo boxes have a selected item
            if (combosize.SelectedItem != null && combocopies.SelectedItem != null && combocolor.SelectedItem != null && pdfData != null && pdfData.Length > 0)
            {
                // Get user selections
                string paperSize = combosize.SelectedItem.ToString();
                string copies = combocopies.SelectedItem.ToString();
                string color = combocolor.SelectedItem.ToString();
                string selectedFileName = filename.Text; // Assuming filename is the name of the textbox

                // Print debug messages
                Console.WriteLine("Selected PDF file received successfully:");
                Console.WriteLine($"  File Name: {selectedFileName}");
                Console.WriteLine($"  Paper Size: {paperSize}");
                Console.WriteLine($"  Copies: {copies}");
                Console.WriteLine($"  Color: {color}");

                // Proceed to the next step or form
                // Example: navigate to the next form
                Form nextForm = new summary(selectedFileName, copies, color, paperSize, pdfData); // Pass the pdfData to the summary form
                nextForm.Show();
                this.Hide();
            }
            else
            {
                // Display a message indicating that all selections are required
                MessageBox.Show("Please select options for all fields and make sure a PDF file is loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void pictureBox4_Click(object sender, EventArgs e)
        {
            file_explorer prev = new file_explorer();
            prev.Show();
            this.Hide();
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


    }
}

