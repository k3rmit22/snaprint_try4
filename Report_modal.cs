using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace snaprint_try4
{
    public partial class Report_modal : Form
    {
        private bool messageSentSuccessfully = false;
        public Report_modal()
        {
            InitializeComponent();
            InitializeKioskMode();
            SetDoubleBuffered();
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
        private void SetDoubleBuffered()
        {
            // Enable double buffering for this form
            this.DoubleBuffered = true;
        }

        int i;
        private void Report_modal_Load(object sender, EventArgs e)
        {

            // Adjust initial position for animation
            this.Location = new Point(this.Left, this.Top - 200); // Move the form up by 200 pixels
            this.Opacity = 0; // Set initial opacity to 0 for a fade-in effect

            // Set a shorter interval for the timer to make the animation appear faster
            modalEffect_Timer.Interval = 20; // Adjust this value as needed

            // Start the timer for animation
            modalEffect_Timer.Start();
        }

        private void modalEffect_Timer_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1 && this.Top >= i)
            {
                modalEffect_Timer.Stop(); // Stop the timer when animation is complete
            }
            else
            {
                Opacity += 0.08; // Increase opacity gradually for fade-in effect
                this.Top += 20; // Move the form downwards for animation

                // Center the modal both horizontally and vertically
                this.CenterToScreen();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Printer out of Paper, please check.";
            DateTime currentDateTime = DateTime.Now;

            string connectionString = "Server=localhost;Port=3306;Database=admin_user;Uid=root;Pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO tbl_reports (issue, datetime) VALUES (@message, NOW())";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@message", message);
                        cmd.ExecuteNonQuery();

                        // Indicate the message was sent successfully
                        messageSentSuccessfully = true;

                        // Close the form after the message is sent
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }



       

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Printer Error occured, Please check";
            DateTime currentDateTime = DateTime.Now;

            string connectionString = "Server=localhost;Port=3306;Database=admin_user;Uid=root;Pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO tbl_reports (issue, datetime) VALUES (@message, NOW())";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@message", message);
                        cmd.ExecuteNonQuery();

                        // Indicate the message was sent successfully
                        messageSentSuccessfully = true;

                        // Close the form after the message is sent
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "Unknown Error occured, please check.";
            DateTime currentDateTime = DateTime.Now;

            string connectionString = "Server=localhost;Port=3306;Database=admin_user;Uid=root;Pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO tbl_reports (issue, datetime) VALUES (@message, NOW())";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@message", message);
                        cmd.ExecuteNonQuery();

                        // Indicate the message was sent successfully
                        messageSentSuccessfully = true;

                        // Close the form after the message is sent
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            // Show the message box after the form is closed
            if (messageSentSuccessfully)
            {
                MessageBox.Show("Message sent to admin successfully!");
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


    
}
