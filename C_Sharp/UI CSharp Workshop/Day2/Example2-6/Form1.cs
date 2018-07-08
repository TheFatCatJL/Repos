using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example2_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MessageTo = "";
            ArrayList MyRadioObjects = new ArrayList()
            { radioButton1, radioButton2,radioButton3,radioButton4,radioButton5};
            ArrayList MyCheckBoxObjects = new ArrayList()
            { checkBox1,checkBox2,checkBox3};
            MessageTo = RadioChecker(MyRadioObjects).ToString() + "flavour ice-cream with " + CheckBoxChecker(MyCheckBoxObjects) + " toppings ordered.";
            MessageBox.Show(MessageTo);
        }

        private StringBuilder RadioChecker(ArrayList MyObjects)
        {
            StringBuilder a = new StringBuilder();
            foreach (RadioButton radio in MyObjects)
            {
                if (radio.Checked == true) { a.Append(radio.Text); a.Append(" "); }
                
            }
            return a;
        }

        private string CheckBoxChecker(ArrayList MyObjects)
        {
            string[] textvalues = new string[3];
            int count = 0;
            string a = "";
            foreach (CheckBox checkbox in MyObjects)
            {
                if (checkbox.Checked == true) { textvalues[count] = checkbox.Text; count++; }
                else { textvalues[count] = ""; count++; }
            }
            if (textvalues[0] !="" && textvalues[1] != "" && textvalues[2] != "")
            { a = textvalues[0] + ", " + textvalues[1] + " and " + textvalues[2]; }
            else if (textvalues[0] != "" && textvalues[1] != "")
            { a = textvalues[0] + " and " + textvalues[1]; }
            else if (textvalues[0] != "" && textvalues[2] != "")
            { a = textvalues[0] + " and " + textvalues[2]; }
            else if (textvalues[1] != "" && textvalues[2] != "")
            { a = textvalues[1] + " and " + textvalues[2]; }
            else if (textvalues[0] != "")
            { a = textvalues[0]; }
            else if (textvalues[1] != "")
            { a = textvalues[1]; }
            else if (textvalues[2] != "")
            { a = textvalues[2]; }
            else { a = ""; }
            return a;
        }

    }
}
