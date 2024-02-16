using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace snaprint_try4
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            snaprint_landing close = new snaprint_landing();
            close.Show();
            this.Hide();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar=true; 
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // In a real application, you would compare against hashed passwords stored in a database
            if (username == "admin" && password == "123")
            {
                try
                {
                    // Admin login successful, open the pricing form
                    pricing open = new pricing();
                    open.FormClosed += (s, args) => this.Show(); // Show this form again when pricing form closes
                    open.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                // Invalid credentials
                MessageBox.Show("Invalid username or password. Please try again.");
            }

            // Clear the password field for security reasons
            txtPassword.Clear();
        }

    }

}
