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
    public partial class Ex1_4_CatchARabbit : Form
    {
        Random rdn;
        public Ex1_4_CatchARabbit()
        {
            InitializeComponent();

            //
            btnRabbit.Image = Image.FromFile(@"..\..\img\rabbit.gif");

            rdn = new Random();
        }

        private void btnRabbit_Click(object sender, EventArgs e)
        {
            int x = rdn.Next(1, Width - btnRabbit.Width - 50);
            int y = rdn.Next(1, Height - btnRabbit.Height - 50);
            btnRabbit.Location = new System.Drawing.Point(x, y);
        }
    }
}
