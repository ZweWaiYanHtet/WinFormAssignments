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
    public partial class _2_4 : Form
    {
        string strChoice = "None";
        public _2_4()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string s = null;
            if (optSmall.Checked == true)
                s = "Small";
            else if (optMedium.Checked == true)
                s = "Medium";
            else
                s = "Big";
            MessageBox.Show(s + " is selected");
            MessageBox.Show(strChoice + " ice cream is selected");
        }

        private void optSmall_CheckedChanged(object sender, EventArgs e)
        {
            strChoice = "Small";
        }

        private void optMedium_CheckedChanged(object sender, EventArgs e)
        {
            strChoice = "Medium";
        }

        private void optBig_CheckedChanged(object sender, EventArgs e)
        {
            strChoice = "Big";
        }

    }
}
