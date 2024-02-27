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
    public partial class modal : Form
    {
        public modal()
        {
            InitializeComponent();
        }

        private void modalEffect_Timer_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                modalEffect_Timer.Stop();
            }
            else
            {
                Opacity += .04;
            }

            // Center the modal both horizontally and vertically
            this.CenterToScreen();

            if (this.Top >= i)
            {
                modalEffect_Timer.Stop();
            }
        }

        int i;
        private void modal_Load(object sender, EventArgs e)
        {
            i = this.Top + 150; // Adjust for desired final position
            this.StartPosition = FormStartPosition.CenterScreen; // Set initial position to center
            this.Location = new Point(this.Left + 220, this.Top + 150); // Adjust for animation
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
