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


namespace snaprint_try4
{
    public partial class browse : Form
    {
        private ManagementEventWatcher removalWatcher;

        public browse()
        {
            InitializeComponent();
            InitializeRemovalWatcher();
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


        private void InitializeRemovalWatcher()
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
                    // Hide the current form (browse)
                    this.Hide();

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
                }
                catch (Exception ex)
                {
                    // Error handling for any exceptions
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }




    private void browse_Load(object sender, EventArgs e)
        {

        }

        private void broswe_button_Click(object sender, EventArgs e)
        {
            file_explorer f2 = new file_explorer();
            f2.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            removalWatcher.Stop();
        }

     
        public static int parentX, parentY;

        private void modal_Click(object sender, EventArgs e)
        {
            Form modalBackgound = new Form();
            using (modal modal = new modal())
            {
                modalBackgound.StartPosition = FormStartPosition.Manual;
                modalBackgound.FormBorderStyle = FormBorderStyle.None;
                modalBackgound.Opacity = .50d;
                modalBackgound.BackColor = Color.Black;
                modalBackgound.Size = this.Size;
                modalBackgound.Location = this.Location;
                modalBackgound.ShowInTaskbar = false;
                modalBackgound.Show();
                modal.Owner = modalBackgound;
                parentX = this.Location.X;
                parentY = this.Location.Y;

                modal.ShowDialog();
                modalBackgound.Dispose();
            }
        }
    }
 }

