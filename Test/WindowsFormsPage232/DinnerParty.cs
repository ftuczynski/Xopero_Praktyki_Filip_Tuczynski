using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPage232
{
    class DinnerParty
    {
        public static decimal CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }

        public decimal Cost
        {
            get
            {
                return (HealthyOption ? 0.95M : 1.0M) * (((CostOfFoodPerPerson + CalculateCostOfBeveragesPerPerson()) * NumberOfPeople) + CalculateCostOfDecorations());
            }
        }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
        }

        private decimal CalculateCostOfDecorations()
        {
            if (FancyDecorations)
                return 50.0M + (NumberOfPeople * 15.0M);
            else
                return 30.0M + (NumberOfPeople * 7.5M);
        }
        private decimal CalculateCostOfBeveragesPerPerson()
        {
            if (HealthyOption)
                return 5.0M;
            else
                return 20.0M;
        }
    }
}
