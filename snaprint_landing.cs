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

namespace snaprint_try4
{
    public partial class snaprint_landing : Form
    {
        private ManagementEventWatcher watcher;
        private bool usbDeviceInserted = false; // Flag to track if USB device is already inserted

        public snaprint_landing()
        {
            InitializeComponent();
            InitializeKioskMode();
            InitializeUSBWatcher();
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

        private void InitializeUSBWatcher()
        {
            // Initialize USB device insertion event watcher
            watcher = new ManagementEventWatcher();
            watcher.EventArrived += DeviceInsertedEvent;
            watcher.Query = new WqlEventQuery("SELECT * FROM __InstanceCreationEvent WITHIN 2 WHERE TargetInstance ISA 'Win32_USBControllerDevice'");
            watcher.Start();
        }


        private void DeviceInsertedEvent(object sender, EventArrivedEventArgs e)
        {
            try
            {
                // Check if USB device insertion event is already handled
                if (usbDeviceInserted)
                    return;

                // Set flag to indicate USB device insertion is handled
                usbDeviceInserted = true;

                // Execute UI-related code on the main thread
                this.Invoke((MethodInvoker)delegate
                {
                    // Close the current form
                    this.Hide();

                    // Check if a browse form is already open
                    browse nextForm = Application.OpenForms.OfType<browse>().FirstOrDefault();
                    if (nextForm == null)
                    {
                        // If browse form is not already open, create and show it
                        nextForm = new browse();
                        nextForm.Show();
                    }
                    else
                    {
                        // If browse form is already open, bring it to the front and show it
                        nextForm.BringToFront();
                        nextForm.Show();
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            watcher.Stop();
        }




        private void snaprint_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }

    

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private bool isBlack = true;
        private Random rand = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Toggle between black and white
            if (isBlack)
            {
                INSERT.ForeColor = Color.Black;
            }
            else
            {
                INSERT.ForeColor = Color.White;
            }

            // Toggle the state for the next tick
            isBlack = !isBlack;

            // Adjust the timer interval for a slower blinking rate
            timer1.Interval = 1000; // Change this value as needed for desired blinking speed
        }

        


        public static int parentX, parentY;


        private void modal_Click(object sender, EventArgs e)
        {
            Form modalBackgound = new Form();
            using (modal modal = new modal())
            {
                modalBackgound.StartPosition= FormStartPosition.Manual;
                modalBackgound.FormBorderStyle = FormBorderStyle.None;
                modalBackgound.Opacity = .50d;
                modalBackgound.BackColor = Color.Black;
                modalBackgound.Size= this.Size;
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
