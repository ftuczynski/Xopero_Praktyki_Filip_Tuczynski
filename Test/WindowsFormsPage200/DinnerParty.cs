using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace WindowsFormsPage200
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople;
        public decimal CostOfBeveragesPerPerson = 20.0M;
        public decimal CostOfDecorations;

        public void SetHealthyOption(bool isHealthy)
        {
            if (isHealthy)
            {
                CostOfBeveragesPerPerson = 5.0M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.0M;
            }
        }
        public void CalculateCostOfDecorations(bool isFancy)
        {
            if(isFancy)
                CostOfDecorations = 50.0M + (NumberOfPeople * 15.0M);
            else
                CostOfDecorations = 30.0M + (NumberOfPeople * 7.5M);
        }
        public decimal CalculateCost(bool isHealthy)
        {
            return (isHealthy ? 0.95M : 1.0M) * (((CostOfFoodPerPerson + CostOfBeveragesPerPerson) * NumberOfPeople) + CostOfDecorations);
        }
    }
}
