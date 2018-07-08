using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESNETWorkshop1._2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBoxCustID_TextChanged(object sender, EventArgs e)
        {
            labelCustomerID.ForeColor = System.Drawing.Color.Black;

            if (!int.TryParse(textBoxCustID.Text, out int a))
            {
                labelCustomerID.ForeColor = System.Drawing.Color.Red;
                toolStripStatusLabel.Text = "Please enter only integers.";
            }
            if (a <= 0)
            {
                labelCustomerID.ForeColor = System.Drawing.Color.Red;
                toolStripStatusLabel.Text = "Please enter only positive integers.";
                Math.Ceiling(1.45);
            }
        }
    }
}
