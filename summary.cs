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
        private string selectedFileName; //display file

        private string selectedCopies;
        private string selectedColor;
        private string selectedPaperSize;
        private byte[] pdfData; // Store the PDF file data here

        public summary(string selectedFileName, string copies, string color, string paperSize, byte[] pdfData)
        {
            InitializeComponent();
            InitializeKioskMode();
           


            this.selectedCopies = copies;
            this.selectedColor = color;
            this.selectedPaperSize = paperSize;
            this.selectedFileName = selectedFileName; // Assign parameter value to the field

            // Display selected items in labels

            labelCopies.Text = copies;
            labelColor.Text = color;
            labelPaperSize.Text = paperSize;
            filename.Text = selectedFileName;

            // Store the PDF file data
            this.pdfData = pdfData;
            // PrintPdf(); ibalik mamaya 
        }

        /*private void PrintPdf()
        {
            try
            {
                using (MemoryStream stream = new MemoryStream(pdfData))
                {
                    using (PrintDocument printDoc = new PrintDocument())
                    {
                        printDoc.PrintPage += (sender, e) =>
                        {
                            using (StreamReader reader = new StreamReader(stream))
                            {
                                string text = reader.ReadToEnd();
                                e.Graphics.DrawString(text, SystemFonts.DefaultFont, System.Drawing.Brushes.Black, e.MarginBounds);
                            }
                        };

                        printDoc.Print();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while printing the PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } */


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




        // Button click event to print PDF

        /* private void button2_Click(object sender, EventArgs e)
 {
     try
     {
         // Check if pdfData is null or empty
         if (pdfData == null || pdfData.Length == 0)
         {
             MessageBox.Show("No PDF file data available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             return;
         }

         // Create a memory stream from the byte array
         using (MemoryStream stream = new MemoryStream(pdfData))
         {
             // Load the PDF document from the memory stream
             using (var image = Image.FromStream(stream))
             {
                 // Create a PrintDocument object
                 PrintDocument pd = new PrintDocument();

                 // Add PrintPage event handler
                 pd.PrintPage += (s, pe) =>
                 {
                     // Draw the image on the print page
                     pe.Graphics.DrawImage(image, pe.MarginBounds);
                 };

                 // Set printer settings
                 PrintDialog printDialog = new PrintDialog();
                 pd.PrinterSettings = printDialog.PrinterSettings;

                 // Print the document
                 pd.Print();
             }
         }

         // Proceed to the loading form
         loading next = new loading();
         next.Show();
         this.Hide();
     }
     catch (Exception ex)
     {
         MessageBox.Show($"An error occurred while printing the PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
     }
 }*/



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
                            using (PrintDialog printDialog = new PrintDialog())
                            {
                                printDialog.Document = printDocument;
                                if (printDialog.ShowDialog() == DialogResult.OK)
                                {
                                    printDocument.Print();
                                }
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

        // Other methods and event handlers...
    

    private void button1_Click(object sender, EventArgs e)
        {
            preferences back = new preferences(selectedFileName,pdfData);
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


    }

}

