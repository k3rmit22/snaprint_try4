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


       /* private void InitializeRemovalWatcher()
        {
            removalWatcher = new ManagementEventWatcher();
            removalWatcher.EventArrived += DeviceRemovedEvent;
            removalWatcher.Query = new WqlEventQuery("SELECT * FROM __InstanceDeletionEvent WITHIN 2 WHERE TargetInstance ISA 'Win32_USBControllerDevice'");
            removalWatcher.Start();
        }

        private bool isEventHandled = false;


        private void DeviceRemovedEvent(object sender, EventArrivedEventArgs e)
        {
            // Ensure the event handler runs on the UI thread
            this.Invoke((MethodInvoker)delegate
            {
                try
                {
                    // Check if a snaprint_landing form is already open
                    snaprint_landing landingForm = Application.OpenForms.OfType<snaprint_landing>().FirstOrDefault();
                    if (landingForm == null)
                    {
                        // If snaprint_landing form is not already open, create and show it
                        landingForm = new snaprint_landing();
                        landingForm.Show();
                    }
                    else
                    {
                        // If snaprint_landing form is already open, bring it to the front
                        landingForm.BringToFront();
                    }

                    // Close the current form (browse)
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Error handling for any exceptions
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }*/




        private void browse_Load(object sender, EventArgs e)
        {

        }
        /*
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            removalWatcher.Stop();
        }
        */
     
       

        private void browse_button_Click(object sender, EventArgs e)
        {
            file_explorer f2 = new file_explorer();
            f2.Show();
            this.Hide();

        }

        private void ejectbutton_Click(object sender, EventArgs e)
        {
            /*/ Display a message box to confirm ejecting the flash drive
            DialogResult result = MessageBox.Show("Are you sure you want to eject the flash drive?", "Eject Flash Drive", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if the user clicked Yes
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Get the list of removable drives
                    DriveInfo[] drives = DriveInfo.GetDrives();

                    // Search for the removable drive (typically starts with "Removable Disk")
                    foreach (DriveInfo drive in drives)
                    {
                        if (drive.DriveType == DriveType.Removable)
                        {
                            // Eject the removable drive
                            EjectDrive(drive.Name);
                            MessageBox.Show($"Flash drive {drive.Name} ejected successfully.", "Eject Flash Drive", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Close the current form
                            this.Close();

                            // Open the desired form
                            snaprint_landing open = new snaprint_landing();
                            open.Show();

                            return;
                        }
                    }

                    // If no removable drive found
                    MessageBox.Show("No flash drive found.", "Eject Flash Drive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
            var drives = DriveInfo.GetDrives().Where(d => d.IsReady & d.DriveType == DriveType.Removable);
            if (drives.FirstOrDefault() != null)
            {
                char driveLetter = Convert.ToChar(drives.FirstOrDefault().Name.Replace(":\\", ""));
                if (EjectPendriveManager.EjectPenDrive(driveLetter))
                {
                    // Ejection was successful, open another form here
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

       




    }
}

