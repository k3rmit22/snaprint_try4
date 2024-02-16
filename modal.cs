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

            int y = snaprint_landing.parentY += 3;
            this.Location = new Point(snaprint_landing.parentX + 220, y);
            if (y >= i)
            {
                modalEffect_Timer.Stop();
            }
        }
        int i;
        private void modal_Load(object sender, EventArgs e)
        {
            i = snaprint_landing.parentY + 150;
            this.Location = new Point(snaprint_landing.parentX+220, snaprint_landing.parentY +150);    
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
