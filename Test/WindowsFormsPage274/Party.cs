using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPage274
{
    class Party
    {
        public static decimal CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }

        private decimal CalculateCostOfDecorations()
        {
            if (FancyDecorations)
                return 50.0M + (NumberOfPeople * 15.0M);
            else
                return 30.0M + (NumberOfPeople * 7.5M);
        }

        virtual public decimal Cost
        {
            get
            {
                return CostOfFoodPerPerson*NumberOfPeople + CalculateCostOfDecorations() + (NumberOfPeople > 12 ? 100M : 0M);
            }
        }
    }
}
