using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPage274
{
    class DinnerParty : Party
    {
        public bool HealthyOption { get; set; }

        override public decimal Cost
        {
            get
            {
                return (HealthyOption ? 0.95M : 1.0M) * ((CalculateCostOfBeveragesPerPerson() * NumberOfPeople) + base.Cost);
            }
        }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
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
