using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DinnerParty
{
    class DinnerParty
    {

        public int NumberOfPeople;
        public decimal CostOfBeverages;
        public decimal CostOfDecorations;

        public bool HealthyOption;
        public decimal TotalCost;

        public const decimal fancyDecorationPerPersonFancy = 15M;
        public const decimal fancyDecorationPerPersonNotFancy = 1.5M;
        public const decimal fancyFee = 50M;
        public const decimal notfancyFee = 30M;


        public void SetHealthyOption(bool healthyOption)
        {
            //uses the value of variable healthyOption to update the CostOfBeveragesPerPerson field based on the healthyOption value
            HealthyOption = healthyOption;
        }

        public decimal CalculateCostOfDecorations(int numberOfPeople, bool fancyDecoration)
        {
            //cost of decorations for the number of people attending the party

            if(fancyDecoration == true)
            {
                CostOfDecorations = (numberOfPeople * fancyDecorationPerPersonFancy) + fancyFee;
            }
            else
            {
                CostOfDecorations = (numberOfPeople * fancyDecorationPerPersonNotFancy) + notfancyFee;
            }
       
            return CostOfDecorations;
        }

        public decimal CalculateCost()
        {
            //calculates total cost by adding the cost of decorations to the cost of the drinks per person
            //if the client wants the Healthy option, apply the discount inside the CalculateCost() method

            TotalCost = CostOfBeverages + CostOfDecorations;

            if(HealthyOption == true)
            {
                TotalCost = TotalCost - (TotalCost * 5 / 100);
            }

            return TotalCost;
        }
    }
}
