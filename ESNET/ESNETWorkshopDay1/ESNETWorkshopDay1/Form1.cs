using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ESNETWorkshopDay1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            bool GoodDataFlag = inputIntegrity();
            if (GoodDataFlag == true)
            {
                string videocode = textBox1.Text;
                string videoprice = textBox2.Text;
                string cmdstring = "exec ChangeVideoPrice " + videoprice +","+ videocode;
                

                using (SqlConnection dafestyconnection = new SqlConnection("Data Source=THEFATCATSTASH;Integrated Security=SSPI;Initial Catalog=DafestyESNET"))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand(cmdstring, dafestyconnection);
                        dafestyconnection.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Wrong Query. Either Video Code do not exist or SQL is experiencing connection errors.");
                    }
                }
            }            
        }

        private bool inputIntegrity()
        {
            string videocodestr = textBox1.Text;
            string videopricestr = textBox2.Text;
            bool gooddataflag = true;
            if (!int.TryParse(videocodestr, out int a))
            {
                MessageBox.Show("Please input integer for video code.");
                gooddataflag = false;
            }
            if (!double.TryParse(videopricestr, out double b))
            {
                MessageBox.Show("Please input valid numbers for price");
                gooddataflag = false;
            }
            if (b < 0)
            {
                MessageBox.Show("Please enter only positive numbers");
                gooddataflag = false;
            }
            return gooddataflag;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            bool GoodDataFlag = inputIntegrity();
            if (GoodDataFlag == true)
            {
                dataGridView1.Rows.Clear();
                DataGridViewRow R = dataGridView1.Rows[dataGridView1.Rows.Add()];
                string videocode = textBox1.Text;
                string cmdstring = "exec ViewVideoPrice " + videocode;
                SqlConnection dafestyconnection = new SqlConnection("Data Source=THEFATCATSTASH;Integrated Security=true;Initial Catalog=DafestyESNET");
                SqlCommand cmd = new SqlCommand(cmdstring, dafestyconnection);

                using (dafestyconnection)
                {
                    try
                    {
                        dafestyconnection.Open();
                        SqlDataReader myreader = cmd.ExecuteReader();
                        myreader.Read();
                        R.Cells[0].Value = myreader.GetValue(0);
                        R.Cells[1].Value = myreader.GetValue(1);
                        myreader.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Wrong Query. Either Video Code do not exist or SQL is experiencing connection errors.");
                    }                    
                    
                }
            }
        }
    }
}
