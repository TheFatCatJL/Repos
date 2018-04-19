using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1_4
{
    public partial class Form1 : Form
    {
        static int counter = 0;
        static System.Timers.Timer RabbitTime = new System.Timers.Timer(15000);
        static bool gameendflag = false;
        public Form1()
        {
            InitializeComponent();
            RabbitTime.Elapsed += new System.Timers.ElapsedEventHandler(RabbitTimeOver);
        }
        
        private void RabbitTimeOver(object sender, EventArgs e)
        {
            MessageBox.Show("In 15s, you have caught the rabbit " + counter + " times");
            RabbitTime.Stop();
            gameendflag = true;
        }
        private void buttonRabbit_Click(object sender, EventArgs e)
        {
            if (gameendflag == true)
            {
                buttonRabbit.Visible = false;
                return;
            }
            counter++;
            int XRndNew = 0, YRndNew = 0;
            bool Exitflag = false;
            Random RanCord = new Random();
            Point OldCord = new Point();
            OldCord = buttonRabbit.Location;
            do
            {
                XRndNew = RanCord.Next(12, 794);
                YRndNew = RanCord.Next(20, 442);
                if (XRndNew > OldCord.X && XRndNew - OldCord.X >= 60 && YRndNew > OldCord.Y && YRndNew - OldCord.Y >= 100) Exitflag = true;
                else if (XRndNew < OldCord.X && OldCord.X - XRndNew >= 60 && YRndNew < OldCord.Y && OldCord.Y - YRndNew >= 100) Exitflag = true;
            } while (Exitflag == false);
            buttonRabbit.Location = new Point(XRndNew, YRndNew);
            label1.Text = String.Format("Number of times you caught the rabbit : " + counter);
            RabbitTime.Start();
        }
    }
}
        

