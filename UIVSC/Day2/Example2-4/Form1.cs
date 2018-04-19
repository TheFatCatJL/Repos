using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s="";
            if (radioButton1.Checked==true) { s = radioButton1.Text; }
            else if (radioButton2.Checked == true) { s = radioButton2.Text; }
            else if (radioButton3.Checked == true) { s = radioButton3.Text; }
            MessageBox.Show(s + " size ice-cream is selected.");

        }
    }
}
