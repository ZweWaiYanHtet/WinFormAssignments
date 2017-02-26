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
    public partial class Ex1_5_KillARabbit : Form
    {
        Random rdn;
        public Ex1_5_KillARabbit()
        {
            InitializeComponent();

            btnRabbit.Image = Image.FromFile(@"..\..\img\happyRabbit.gif");
            btnRabbit.Height += 20;

            rdn = new Random();
        }

        private void btnRabbit_MouseDown(object sender, MouseEventArgs e)
        {
            btnRabbit.Image = Image.FromFile(@"..\..\img\sadRabbit.gif");
        }

        private void btnRabbit_MouseUp(object sender, MouseEventArgs e)
        {
            btnRabbit.Image = Image.FromFile(@"..\..\img\happyRabbit.gif");

            int x = rdn.Next(1, Width - btnRabbit.Width - 50);
            int y = rdn.Next(1, Height - btnRabbit.Height - 50);
            btnRabbit.Location = new System.Drawing.Point(x, y);
        }
    }
}
