using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example2_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sizechoice="", flavourchoice="";
            StringBuilder ToppingChoice = new StringBuilder();
            ArrayList CheckB = new ArrayList() { checkBox1, checkBox2, checkBox3 };

            if (comboBox1.SelectedIndex == 0) { sizechoice = "Small"; }
            else if (comboBox1.SelectedIndex == 1) { sizechoice = "Medium"; }
            else if (comboBox1.SelectedIndex == 2) { sizechoice = "Large"; }
            else if (comboBox1.SelectedIndex == 3) { sizechoice = "Xtra Large"; }
            else sizechoice = "No Size";
            if (sizechoice == "No Size")
            {
                MessageBox.Show("Please chooce the ice-cream size.");
            }

            if (radioButton1.Checked == true) { flavourchoice = radioButton1.Text; }
            else if (radioButton2.Checked == true) { flavourchoice = radioButton2.Text; }
            int i = CheckB.Count;
            int j = 1;
            foreach (CheckBox ChkB in CheckB)
            {
                if (ChkB.Checked == true && j!=i)
                {
                    ToppingChoice.Append(ChkB.Text);
                    ToppingChoice.Append(" ");
                }
                else if (ChkB.Checked == true && j == i)
                {
                    ToppingChoice.Append(ChkB.Text);
                }
                j++;
            }
            string s = (ToppingChoice.ToString()).Trim();
            s = s.Replace(" ", " + ");
            string MessageTo = String.Format("{0} {1} ice-cream with {2} toppings selected.",sizechoice,flavourchoice,s);
            if (sizechoice != "No Size") MessageBox.Show(MessageTo);
        }
    }
}
