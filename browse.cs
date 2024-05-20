using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Printing;
using System.Drawing.Printing;




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
           //CheckPrinterStatus();

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
            this.Close();

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
                    this.Close(); // Hide the current form if needed
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

        private void modal_Click(object sender, EventArgs e)
        {
            modal2 show = new modal2();
            show.Show();
        }

        /*
        private void CheckPrinterStatus()
        {
            try
            {
                string defaultPrinterName = new PrinterSettings().PrinterName;
                string query = $"SELECT * from Win32_Printer WHERE Name LIKE '%{defaultPrinterName}%'";
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
                ManagementObjectCollection coll = searcher.Get();

                foreach (ManagementObject printer in coll)
                {
                    string printerStatus = printer["PrinterStatus"].ToString();
                    string printerState = printer["PrinterState"].ToString();

                    // Check printer status
                    if (printerStatus == "3" || printerState == "4")
                    {
                        Console.WriteLine("Printer status: Printer is idle and ready.");
                    }
                    else if (printerStatus == "4")
                    {
                        Console.WriteLine("Printer status: Printer is printing.");
                    }
                    else if (printerStatus == "5")
                    {
                        Console.WriteLine("Printer status: Printer is warmup.");
                    }
                    else if (printerStatus == "6")
                    {
                        Console.WriteLine("Printer status: Printer is stopped.");
                    }
                    else if (printerStatus == "7")
                    {
                        Console.WriteLine("Printer status: Printer is offline.");
                    }
                    else if (printerStatus == "8")
                    {
                        Console.WriteLine("Printer status: Printer is offline.");
                    }
                    else if (printerStatus == "9")
                    {
                        Console.WriteLine("Printer status: Printer is paper jammed.");
                    }
                    else if (printerStatus == "10")
                    {
                        Console.WriteLine("Printer status: Printer is out of paper.");
                    }
                    else if (printerStatus == "11")
                    {
                        Console.WriteLine("Printer status: Printer needs user intervention.");
                    }
                    else
                    {
                        Console.WriteLine("Printer status: Unknown printer status.");
                    }

                    // Check if printer is low on ink
                    if (printer["ExtendedPrinterStatus"].ToString() == "3")
                    {
                        Console.WriteLine("Printer is low on ink.");
                    }

                    // Check if printer is offline
                    if (printer["ExtendedPrinterStatus"].ToString() == "2")
                    {
                        Console.WriteLine("Printer is offline.");
                    }
                }
            }
            catch (ManagementException e)
            {
                Console.WriteLine("An error occurred while querying WMI: " + e.Message);
            }
        }  */
    } 
        




}


