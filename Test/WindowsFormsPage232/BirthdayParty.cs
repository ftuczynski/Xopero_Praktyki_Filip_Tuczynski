using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPage232
{
    class BirthdayParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public string CakeWriting { get; set; }
        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLenght())
                    return true;
                else
                    return false;
            }
        }
        private int ActualLenght
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLenght())
                    return MaxWritingLenght();
                else
                    return CakeWriting.Length;
            }
        }
        public decimal Cost
        {
            get
            {
                return CalculateCostOfDecorations() + (CostOfFoodPerPerson * NumberOfPeople)
                    + (CakeSize() == 8 ? 40M + ActualLenght * .25M : 75M + ActualLenght * .25M)
                    + (NumberOfPeople > 12 ? 100M : 0M);
            }
        }


        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }

        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
                return 8;
            else
                return 16;
        }
        private int MaxWritingLenght()
        {
            if (CakeSize() == 8)
                return 16;
            else
                return 40;
        }
        private decimal CalculateCostOfDecorations()
        {
            if (FancyDecorations)
                return 50.0M + (NumberOfPeople * 15.0M);
            else
                return 30.0M + (NumberOfPeople * 7.5M);
        }
    }
}
