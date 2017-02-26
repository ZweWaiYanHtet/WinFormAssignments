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
    public partial class Ex_2_8 : Form
    {
        string strFlavor;
        public Ex_2_8()
        {
            InitializeComponent();
        }

        private void Ex_2_8_Load(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string s, f;
            string t;
            if (cboSize.Text == "Small")
                s = "Small";
            else if (cboSize.Text == "Medium")
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
            MessageBox.Show("A " + strFlavor + " flavored ice cream" + t + " is selected");
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
