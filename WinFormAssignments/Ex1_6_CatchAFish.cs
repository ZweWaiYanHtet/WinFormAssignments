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
    public partial class Ex1_6_CatchAFish : Form
    {
        Random rdn;
        public Ex1_6_CatchAFish()
        {
            InitializeComponent();

            btnFish.Image = Image.FromFile(@"..\..\img\fish2.bmp");

            rdn = new Random();
        }

        private void btnFish_MouseEnter(object sender, EventArgs e)
        {
            int x = rdn.Next(1, Width - btnFish.Width - 50);
            int y = rdn.Next(1, Height - btnFish.Height - 50);
            btnFish.Location = new System.Drawing.Point(x, y);
        }
    }
}
