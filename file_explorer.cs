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
        private string filePath = "D:";
        private bool isFile = false;
        private string currentlySelectedItemName = "";
       

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
            Filepathtextbox.Text = filePath;
            loadFilesAndDirectories();
        }



        public void loadFilesAndDirectories()
        {
            DirectoryInfo fileList = null;
            string tempFilePath = "";
            FileAttributes fileAttr;

            try
            {
                if (isFile)
                {
                    tempFilePath = filePath + "/" + currentlySelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    filenamelabel.Text = fileDetails.Name;
                    filetypelabel.Text = fileDetails.Extension;
                    fileAttr = File.GetAttributes(tempFilePath);
                    //Process.Start(tempFilePath); //view file but not inside the forms
                }
                else
                {
                    fileAttr = File.GetAttributes(filePath);

                }


                var drives = DriveInfo.GetDrives().Where(d => d.DriveType == DriveType.Removable);

                
                if (drives.Any())
                {
                    
                    var flashDrive = drives.First();
                    fileList = new DirectoryInfo(filePath);
              
                    DirectoryInfo[] dirs = fileList.GetDirectories(); // GET ALL THE DIRS
                    
                    listView1.Items.Clear();

                    fileList = new DirectoryInfo(filePath);
                 
                    foreach (var file in fileList.GetFiles())
                    {
                        if (file.Extension.ToUpper() == ".PDF")
                        {
                            listView1.Items.Add(file.Name, 0);
                        }
                    }
                }
                else
                {
                    filenamelabel.Text = this.currentlySelectedItemName;
                    MessageBox.Show("No flash drive detected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    snaprint_landing error = new snaprint_landing();
                    error.Show();
                    this.Hide();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error occurred: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                snaprint_landing error = new snaprint_landing();
                error.Show();
                this.Hide();
            }
        }
        public void loadButtonAction()
        {
            removeBackSlash();
            filePath = Filepathtextbox.Text;
            loadFilesAndDirectories();
            isFile = false;

        }


        private void Gobutton_Click(object sender, EventArgs e)
{
    if (listView1.SelectedItems.Count > 0)
    {
        // Get the name of the selected item
        string selectedFileName = listView1.SelectedItems[0].Text;

        // Display a confirmation message box
        DialogResult result = MessageBox.Show($"Are you sure you want to open '{selectedFileName}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        // Check if the user clicked Yes
        if (result == DialogResult.Yes)
        {
            // Proceed with loading the selected file
            // Pass the selected file name to the constructor of the preferences form
            preferences show = new preferences(selectedFileName);

            // Show the preferences form
            show.Show();
            
            // Hide the current form
            this.Hide();
        }
    }
    else
    {
        // If no item is selected, display an error message
        MessageBox.Show("Please select a file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}


        public void removeBackSlash()
        {
            string path = Filepathtextbox.Text;
            if (path.LastIndexOf("/") == path.Length - 1)
            {

                Filepathtextbox.Text = path.Substring(0, path.Length - 1);
            }
        }

        public void goBack()
        {
            try
            {
                removeBackSlash();
                string path = Filepathtextbox.Text;
                path = path.Substring(0, path.LastIndexOf("/"));
                this.isFile = false;
                Filepathtextbox.Text = path;
                removeBackSlash();
            }
            catch (Exception e)
            {

            }
        }



        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;
            FileAttributes fileAttr = File.GetAttributes(filePath + "/" + currentlySelectedItemName);
            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                Filepathtextbox.Text = filePath + "/" + currentlySelectedItemName;
            }
            else
            {
                isFile = true;
            }
        }


        private void Backbutton_Click_1(object sender, EventArgs e)
        {
            // Perform default back action
            goBack();
            loadButtonAction();

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadButtonAction();

        }

        private void buttonhome_Click(object sender, EventArgs e)
        {
            browse balik = new browse();
            balik.Show();
            this.Close();
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