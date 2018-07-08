using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* Form Height : 300 
             *  Form Width : 400 
             *  Button Text : “Reset” 
             *  Button Font : Arial and Bold 
             *  Button Position : 200 , 200
            
            this.Size = new Size(400, 300);
            button1.Text = "Reset";
            button1.Font = new Font("Arial", 8, FontStyle.Bold);
            button1.Location = new Point(200,200);
            */
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(200, 200);
            this.button1.Text = "Reset";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
        }
    }
}
