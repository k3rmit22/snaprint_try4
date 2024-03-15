using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;


namespace snaprint_try4
{
    public partial class browse : Form
    {
        private ManagementEventWatcher removalWatcher;

        public browse()
        {
            InitializeComponent();
            //InitializeRemovalWatcher();
            InitializeKioskMode();
            SetDoubleBufferred();

        }

        private void SetDoubleBufferred()
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



        private void browse_Load(object sender, EventArgs e)
        {

        }
      
       

        private void browse_button_Click(object sender, EventArgs e)
        {
            file_explorer f2 = new file_explorer();
            f2.Show();
            this.Hide();

        }

        private void ejectbutton_Click(object sender, EventArgs e)
        {
            var drives = DriveInfo.GetDrives().Where(d => d.IsReady && d.DriveType == DriveType.Removable);
            if (drives.FirstOrDefault() != null)
            {
                char driveLetter = Convert.ToChar(drives.FirstOrDefault().Name.Replace(":\\", ""));
                if (FlashDriveEjector.EjectPenDrive(driveLetter))
                {
                    // Display a message box for successful ejection
                    MessageBox.Show("Flash drive ejected successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open another form (snaprint_landing)
                    snaprint_landing form = new snaprint_landing();
                    form.Show();
                    this.Hide(); // Hide the current form if needed
                }
                else
                {
                    MessageBox.Show("Failed to eject the flash drive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No Pendrive Connected...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }







    }
}

