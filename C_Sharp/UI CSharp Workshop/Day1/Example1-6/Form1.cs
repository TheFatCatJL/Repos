using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fishButton_MouseHover(object sender, EventArgs e)
        {
            int FishXCoord, FishYCoord;
            int MouseXCoord, MouseYCoord;
            int XMinBoundary, YMinBoundary;
            int XMaxBoundary, YMaxBoundary;
            Random RandChoice = new Random();
            MouseXCoord = MousePosition.X;
            MouseYCoord = MousePosition.Y;
            XMaxBoundary = this.Width - fishButton.Width;
            YMaxBoundary = this.Height - fishButton.Height;
            XMinBoundary = fishButton.Width;
            YMinBoundary = fishButton.Height;
            FishXCoord = MouseXCoord;
            FishYCoord = MouseYCoord;


            //Border checker
            if (FishXCoord < 12 || FishYCoord <12 || FishXCoord > XMaxBoundary - 125 || FishYCoord > YMaxBoundary - 70)
            {
                FishXCoord = RandChoice.Next(XMinBoundary, XMaxBoundary);
                FishYCoord = RandChoice.Next(YMinBoundary, YMaxBoundary);
            }
            fishButton.Location = new Point(FishXCoord, FishYCoord);
        }

    }
}
