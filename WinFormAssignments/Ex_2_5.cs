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
    public partial class _2_5 : Form
    {
        string strSize, strFlavor;
        public _2_5()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string s, f;

            if (optSmall.Checked)
                s = "Small";
            else if (optMedium.Checked)
                s = "Medium";
            else
                s = "Big";

            if (optChoc.Checked)
                f = "Chocolate";
            else
                f = "Strawberry";

            MessageBox.Show("A " + s + " " + f + " flavored ice cream is selected");
            MessageBox.Show("A " + strSize + " " + strFlavor + " flavored ice cream is selected");
        }

        private void _2_5_Load(object sender, EventArgs e)
        {

        }

        private void optSmall_CheckedChanged(object sender, EventArgs e)
        {
            strSize = "Small";
        }

        private void optMedium_CheckedChanged(object sender, EventArgs e)
        {
            strSize = "Medium";
        }

        private void optBig_CheckedChanged(object sender, EventArgs e)
        {
            strSize = "Big";
        }

        private void optChoc_CheckedChanged(object sender, EventArgs e)
        {
            strFlavor = "Chocolate";
        }

        private void optStraw_CheckedChanged(object sender, EventArgs e)
        {
            strFlavor = "Strawberry";
        }
    }
}
