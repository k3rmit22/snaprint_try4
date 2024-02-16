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
    public partial class pricing : Form
    {
        public pricing()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            login open=new login();
            open.Show();
            this.Hide();
        }
    }
}
