using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatAtTheRaces
{
    class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {

            return "abc";
        }

        public int PayOut(int Winner)
        {

            return 1;
        }
    }
}
