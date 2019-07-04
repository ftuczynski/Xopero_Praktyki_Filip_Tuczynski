using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
        }
        public void ClearBet()
        {
            MyBet.Amount = 0;
        }
        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            if (BetAmount > Cash)
            {
                return false;
            }
            else
            {
                MyBet = new Bet()
                {
                    Amount = BetAmount,
                    Dog = DogToWin,
                    Bettor = this
                };
                return true;
            }
        }
        public void Collect(int Winner)
        {
            if (MyBet != null)
            {
                Cash+=MyBet.PayOut(Winner);
                ClearBet();
                UpdateLabels();
            }
            
        }
    }
}
