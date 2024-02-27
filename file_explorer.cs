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
using System.Diagnostics;
using System.IO;


namespace snaprint_try4
{
    public partial class file_explorer : Form
    {
        private string flashDrivePath = "";
        public file_explorer()
        {
            InitializeComponent();
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


        private void file_explorer_Load(object sender, EventArgs e)
        {
            LoadFlashDrive();
        }



        private void LoadFlashDrive()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.DriveType == DriveType.Removable && drive.IsReady)
                {
                    flashDrivePath = drive.RootDirectory.FullName;
                    LoadFilesFromFlashDrive();
                    break;
                }
            }
        }

        private void LoadFilesFromFlashDrive()
        {
            if (!string.IsNullOrEmpty(flashDrivePath) && Directory.Exists(flashDrivePath))
            {
                listView1.Items.Clear();

                string[] files = Directory.GetFiles(flashDrivePath);
                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    listView1.Items.Add(fileName);
                }
            }
            else
            {
                MessageBox.Show("Flash drive not detected.");
            }
        }
    }
}

