using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPage274
{
    class BirthdayParty : Party
    {
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
        override public decimal Cost
        {
            get
            {
                return (CakeSize() == 8 ? 40M + ActualLenght * .25M : 75M + ActualLenght * .25M) + base.Cost;
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
    }
}
