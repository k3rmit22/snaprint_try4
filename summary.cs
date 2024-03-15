﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace snaprint_try4
{
    public partial class summary : Form
    {
        private string selectedFileName; //display file

        //get preferences
        private string selectedCopies;
        private string selectedColor;
        private string selectedPaperSize;

        private Dictionary<string, decimal> prices;

        public summary(string selectedFileName, string copies, string color, string paperSize)
        {
            InitializeComponent();
            InitializeKioskMode();
            SetDoubleBuffered();



            // Assign values to fields
            this.selectedCopies = copies;
            this.selectedColor = color;
            this.selectedPaperSize = paperSize;
            this.selectedFileName = selectedFileName; // Assign parameter value to the field

            // Display selected items in labels
            labelCopies.Text = copies;
            labelColor.Text = color;
            labelPaperSize.Text = paperSize;

            // Display the selected file name in the TextBox
            filename.Text = selectedFileName;

            //display price
            CalculateAndDisplayPrice();
            
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
        //next button
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            loading next = new loading();
            next.Show();
            this.Hide();
        }

        private void SetDoubleBuffered()
        {
            // Enable double buffering for this form
            this.DoubleBuffered = true;
        }


        private void CalculateAndDisplayPrice()
        {
            // Initialize hardcoded prices
            Dictionary<string, decimal> prices = new Dictionary<string, decimal>();
            prices.Add("Colored", 10m); // 10 pesos per page for colored ink
            prices.Add("Greyscale", 5m); // 5 pesos per page for greyscale ink
            prices.Add("2 Copies (Colored/Greyscale)", 20m); // 20 pesos per page for 2 copies
            prices.Add("3 Copies (Colored/Greyscale)", 30m); // 30 pesos per page for 3 copies
            prices.Add("4 Copies (Colored/Greyscale)", 40m); // 40 pesos per page for 4 copies
            prices.Add("5 Copies (Colored/Greyscale)", 50m); // 50 pesos per page for 5 copies

            // Calculate total price based on selected items
            decimal totalPrice = 0;

            // Add price for ink color
            if (selectedColor == "Colored" || selectedColor == "Greyscale")
            {
                totalPrice += prices.ContainsKey(selectedColor) ? prices[selectedColor] : 0;
            }

            // Add price for selected copies
            if (selectedCopies == "2 Copies (Colored/Greyscale)" || selectedCopies == "3 Copies (Colored/Greyscale)" || selectedCopies == "4 Copies (Colored/Greyscale)" || selectedCopies == "5 Copies (Colored/Greyscale)")
            {
                totalPrice += prices.ContainsKey(selectedCopies) ? prices[selectedCopies] : 0;
            }

            // Display total price in label
            labelPrice.Text = totalPrice.ToString("N0") + " pesos"; // "N0" format for whole number
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a file is selected
                if (!string.IsNullOrEmpty(selectedFileName))
                {
                    // Log the selected file path
                    Console.WriteLine($"Selected file path: {selectedFileName}");

                    // Validate file existence
                    if (File.Exists(selectedFileName))
                    {
                        // Print the selected PDF file
                        PrintPDF(selectedFileName);
                    }
                    else
                    {
                        MessageBox.Show("The selected file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a PDF file to print.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Display the loading form
                loading next = new loading();
                next.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void PrintPDF(string filePath)
        {
            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Create a PrintDocument object
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += (sender, e) =>
                {
                    // Load the PDF file and draw it on the PrintPage event
                    e.Graphics.DrawImage(Image.FromFile(filePath), e.PageBounds);
                };

                // Start printing
                pd.Print();
            }
            else
            {
                MessageBox.Show("File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            preferences back = new preferences(selectedFileName);
            back.Show();
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

