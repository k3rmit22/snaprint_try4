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
    public partial class snaprint_landing : Form
    {
        private ManagementEventWatcher watcher;

        public snaprint_landing()
        {
            InitializeComponent();

            // Initialize USB device insertion event watcher
            watcher = new ManagementEventWatcher();
            watcher.EventArrived += new EventArrivedEventHandler(DeviceInsertedEvent);
            watcher.Query = new WqlEventQuery("SELECT * FROM __InstanceCreationEvent WITHIN 2 WHERE TargetInstance ISA 'Win32_USBControllerDevice'");
            watcher.Start();

        }
        private bool usbDeviceInserted = false; // Flag to track if USB device is already inserted

        private void DeviceInsertedEvent(object sender, EventArrivedEventArgs e)
        {
            try
            {
                // Check if USB device insertion event is already handled
                if (usbDeviceInserted)
                    return;

               //essageBox.Show("USB device inserted!"); // Debugging message

                // Set flag to indicate USB device insertion is handled
                usbDeviceInserted = true;

                // Execute UI-related code on the main thread
                this.Invoke((MethodInvoker)delegate
                {
                    // Create and show the browse form
                    browse nextForm = new browse();
                    nextForm.Show();

                    // Hide the current form instead of closing it
                    this.Hide();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void snaprint_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
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

        private void PUBLIC_Click(object sender, EventArgs e)
        {
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            watcher.Stop();
        }
    }
}
