using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_At_The_Races
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RaceTrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random MyRandom;

        public bool Run()
        {
            MyRandom = new Random();

            int distance = MyRandom.Next(1, 4);

            MyPictureBox.Left = StartingPosition + Location;

            return true;
        }

        public void TakeStartingPosition()
        {
            Location = StartingPosition;
            MyPictureBox.Left = 0;
        }
               
    }
}
