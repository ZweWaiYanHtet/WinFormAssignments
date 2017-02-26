using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAssignments
{
    public partial class Ex_1_7_CatchAGenie : Form
    {
        public Ex_1_7_CatchAGenie()
        {
            InitializeComponent();

            picLamp.Image = Image.FromFile(@"..\..\img\magic-lamp.gif");
            picGenie.Image = Image.FromFile(@"..\..\img\Genie.gif");
        }

        private void picLamp_Click(object sender, EventArgs e)
        {
            picGenie.Visible = true;
        }

        private void picLamp_MouseMove(object sender, MouseEventArgs e)
        {
            picGenie.Visible = false;
        }

        private void picLamp_DoubleClick(object sender, EventArgs e)
        {
            picGenie.Width *= 2;
            picGenie.Height *= 2;
        }
    }
}
