using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string size = "", flavour = "";
            if (radioButton1.Checked == true) { size = "Small"; }
            else if (radioButton2.Checked == true) { size = "Medium"; }
            else if (radioButton3.Checked == true) { size = "Large"; }
            if (radioButton4.Checked == true) { flavour = "Chocolate"; }
            else if (radioButton5.Checked == true) { flavour = "Strawberry"; }
            MessageBox.Show($"{size} {flavour} flavour ice-cream selected.");
        }
    }
}
