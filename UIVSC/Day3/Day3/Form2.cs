using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForm newCMForm = new MyForm();
            newCMForm.MdiParent = this;
            newCMForm.Show();
            openToolStripMenuItem.Enabled = false;
            closeToolStripMenuItem.Enabled = true;
            newCMForm.FormClosed += new System.Windows.Forms.FormClosedEventHandler(closeformops);
        }

        private void closeformops(object sender, FormClosedEventArgs e)
        {
            openToolStripMenuItem.Enabled = true;
            closeToolStripMenuItem.Enabled = false;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
            openToolStripMenuItem.Enabled = true;
            closeToolStripMenuItem.Enabled = false;
        }
    }
}
