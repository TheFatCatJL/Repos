using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1_5
{
    public partial class Form1 : Form
    {
        Timer RabbitTimer;
        public Form1()
        {
            InitializeComponent();
            RabbitTimer = ExecuteRabbitTimer();
        }

        public Timer ExecuteRabbitTimer()
        {
            Timer RabbitDeathTimer = new Timer();
            RabbitDeathTimer.Tick += new EventHandler(RabbitDeathEvent);
            RabbitDeathTimer.Interval = 3000;
            return RabbitDeathTimer;
        }

        private void RabbitDeathEvent(object sender, EventArgs e)
        {
            RabbitTimer.Stop();
            MessageBox.Show("The rabbit is dead!");
            buttonRabbit.Enabled = false;
            buttonRabbit.Text = "R.I.P";
            buttonRabbit.Image = Image.FromFile(@"C:\Users\User\source\repos\Day1\Example1-5\deadrabbit.jpg");
        }

        private void buttonRabbit_MouseDown(object sender, MouseEventArgs e)
        {
            buttonRabbit.Image = Image.FromFile(@"C:\Users\User\source\repos\Day1\Example1-5\sadrabbit.jpg");
            buttonRabbit.Text = "Nooo!";
            RabbitTimer.Start();
        }

        private void buttonRabbit_MouseUp(object sender, MouseEventArgs e)
        {
            RabbitTimer.Stop();
            Point RabbitCoord = new Point();
            Random RandCoord = new Random();
            bool CoordinateFlag = false;

            int OldCX, OldCY, NewCX, NewCY;

            OldCX = RabbitCoord.X;
            OldCY = RabbitCoord.Y;

            do
            {
                NewCX = RandCoord.Next(12, 802);
                NewCY = RandCoord.Next(12, 424);
                if (NewCX < OldCX && OldCX - NewCX >70) { CoordinateFlag = true; }
                else if (NewCX > OldCX && NewCX - OldCX > 70) { CoordinateFlag = true; }
                if (NewCY < OldCY && OldCY - NewCY < 125) { CoordinateFlag = false; }
                else if (NewCY > OldCY && NewCY - OldCY < 125) { CoordinateFlag = false; }
            } while (CoordinateFlag==false);
            buttonRabbit.Location = new Point(NewCX, NewCY);
            buttonRabbit.Image = Image.FromFile(@"C:\Users\User\source\repos\Day1\Example1-5\smugrabbit.jpg");
            buttonRabbit.Text = "Catch ME!";
        }
    }
}
