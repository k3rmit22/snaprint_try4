using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;


namespace snaprint_try4
{
    public partial class browse : Form
    {
        private ManagementEventWatcher removalWatcher;

        public browse()
        {
            InitializeComponent();
            InitializeRemovalWatcher();
        }

        private void InitializeRemovalWatcher()
        {
            removalWatcher = new ManagementEventWatcher();
            removalWatcher.EventArrived += DeviceRemovedEvent;
            removalWatcher.Query = new WqlEventQuery("SELECT * FROM __InstanceDeletionEvent WITHIN 2 WHERE TargetInstance ISA 'Win32_USBControllerDevice'");
            removalWatcher.Start();
        }

        private void DeviceRemovedEvent(object sender, EventArrivedEventArgs e)
        {
         // MessageBox.Show("USB device removed event triggered!"); // Debugging message

            this.Invoke((MethodInvoker)delegate
            {
                // Display the snaprint_landing form
                snaprint_landing landingForm = new snaprint_landing();
                landingForm.Show();

                // Close the current form
                this.Close();
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

