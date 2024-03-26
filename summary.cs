using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Drawing;
using PdfiumViewer;





namespace snaprint_try4
{
    public partial class summary : Form
    {
        private string printingOption;
        private string selectedFileName; //display file

        private string selectedCopies;
        private string selectedColor;
        private string selectedPaperSize;
        private byte[] pdfData; // Store the PDF file data here
        private string selectedFilePath;


        private double totalPrice;

        public summary(string selectedFileName, string copies, string color, string paperSize, byte[] pdfData, double totalPrice, string printingOption)
        {
            InitializeComponent();
            InitializeKioskMode();
            SetDoubleBufferred();



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
            this.Hide();
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


    }

}

