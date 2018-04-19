using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void pictureBox1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            pictureBox2.Width = 120;
            pictureBox2.Height = 120;
            pictureBox2.Width = pictureBox2.Width * 2;
            pictureBox2.Height = pictureBox2.Height * 2;
            pictureBox2.Visible = true;
        }
    }
}
