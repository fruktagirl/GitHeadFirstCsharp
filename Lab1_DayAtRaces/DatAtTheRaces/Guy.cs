using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DatAtTheRaces
{
    class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            // Set my label to my bet’s description, and the label on my
            // radio button to show my cash (“Joe has 43 bucks”)
            
            MyRadioButton.Text = Name + " has " + Cash + " bucks";

        }

        public void ClearBet()
        {
            // Reset my bet so it’s zero
        }

        public bool PlaceBet(int Amount, int Dog)
        {
            // Place a new bet and store it in my bet field
            // Return true if the guy had enough money to bet

            return true;
        }

        public void Collect(int Winner)
        {

        }
    }
}
