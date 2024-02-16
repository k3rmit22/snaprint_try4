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
    public partial class preferences : Form
    {
        public preferences()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            summary next = new summary();
            next.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            file_explorer prev = new file_explorer();
            prev.Show();
            this.Hide();
        }

    }
}
