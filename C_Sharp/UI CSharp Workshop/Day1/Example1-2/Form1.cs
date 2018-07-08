using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Control a = (Control)sender;
            MessageBox.Show(a.Name + " has been clicked.");
            MessageBox.Show("Height is = " + a.Height + " and Width is = " + a.Width);
        }
    }
}
