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
    public partial class Ex_2_10 : Form
    {
        string strSize, strFlavor;
        public Ex_2_10()
        {
            InitializeComponent();
        }

        private void Ex_2_10_Load(object sender, EventArgs e)
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

            if (lboTopping.SelectedItems.Count == 0)
                t = " with no toppings";
            else
            {
                t = " with toppings:";
                for (int i = 0; i < lboTopping.SelectedItems.Count; i++)
                {
                    t += " " + lboTopping.SelectedItems[i].ToString();
                }


            }


            MessageBox.Show("A " + s + " " + strFlavor + " flavored ice cream" + t + " is selected");
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
