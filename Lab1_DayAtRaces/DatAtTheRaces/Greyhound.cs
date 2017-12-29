using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DatAtTheRaces
{
    class Greyhound
    {
        public int StartingPosition;
        public int RaceTrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;

        public bool Run()
        {

            return true; //if the dog won the race
        }

        public void TakeStartingPosition()
        {
            //reset dog location to the start line
        }
    }
}
