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
        private string selectedFilePath;

        private double totalPrice;

        public summary(string selectedFileName, string copies, string color, string paperSize, byte[] pdfData, double totalPrice)
        {
            InitializeComponent();
            InitializeKioskMode();
            SetDoubleBufferred();



            this.selectedCopies = copies;
            this.selectedColor = color;
            this.selectedPaperSize = paperSize;
            this.selectedFileName = selectedFileName; // Assign parameter value to the field
            this.totalPrice = totalPrice;

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

