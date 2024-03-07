using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace snaprint_try4
{
    public partial class preferences : Form
    {
        private string selectedFileName;

        public preferences()
        {
        }

        public preferences(string selectedFileName)
        {
            InitializeComponent();
            InitializeKioskMode();

            // Set the selected file name
            this.selectedFileName = selectedFileName;

            // Display the selected file name in the filename TextBox
            filename.Text = selectedFileName;
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
            if (combosize.SelectedItem != null && combocopies.SelectedItem != null && combocolor.SelectedItem != null)
            {
                // Get user selections
                string paperSize = combosize.SelectedItem.ToString();
                string copies = combocopies.SelectedItem.ToString();
                string color = combocolor.SelectedItem.ToString();

                // Get the selected file name
                string selectedFileName = filename.Text; // Assuming filename is the name of the textbox

                // Proceed to the next step or form
                // Example: navigate to the next form
                Form nextForm = new summary(selectedFileName, copies, color, paperSize);
                nextForm.Show();
                this.Hide();
            }
            else
    {
        // Display a message indicating that all selections are required
        MessageBox.Show("Please select options for all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                handleParams.ExStyle = 0x02000000;
                return handleParams;
            }
        }




    }
}

