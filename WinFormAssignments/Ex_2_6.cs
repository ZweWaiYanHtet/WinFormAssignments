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
    public partial class Ex_2_6 : Form
    {
        string strSize, strFlavor;
        public Ex_2_6()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string s, f;
            string t;
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

            if (!chkNuts.Checked && !chkRaisins.Checked && !chkChocolateChips.Checked)
                t = " with no topping";
            else
            {
                t = " with topping";
                if (chkNuts.Checked)
                    t += " Nuts";
                if (chkRaisins.Checked)
                    t += " Raisins";
                if (chkChocolateChips.Checked)
                    t += " Chocolate-Chips";
            }

            MessageBox.Show("A " + s + " " + f + " flavored ice cream is selected");
            MessageBox.Show("A " + strSize + " " + strFlavor + " flavored ice cream" + t + " is selected");
        }

        private void Ex_2_6_Load(object sender, EventArgs e)
        {

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

        private void optSmall_CheckedChanged(object sender, EventArgs e)
        {
            strSize = "Small";
        }
    }
}
