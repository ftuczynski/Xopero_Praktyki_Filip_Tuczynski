using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPage382 {
    class CardComparer_byValue : IComparer<Card> {
        public int Compare(Card x, Card y) {
            if (x.Value > y.Value)
                return 1;
            if (x.Value < y.Value)
                return -1;
            if (x.Suit > y.Suit)
                return 1;
            if (x.Suit < y.Suit)
                return -1;
            return 0;
        }
    }

    class CardComparer_bySuit : IComparer<Card> {
        public int Compare(Card x, Card y) {
            if (x.Suit > y.Suit)
                return 1;
            if (x.Suit< y.Suit)
                return -1;
            if (x.Value > y.Value)
                return 1;
            if (x.Value < y.Value)
                return -1;
            return 0;
            return 0;
        }
    }

    class Card {
        public Suits Suit { get; set; }
        public Values Value { get; set; }
        public string Name {
            get {
                return Value.ToString() + " of " + Suit.ToString();
            }
        }

        public Card(Suits suit,Values value) {
            this.Suit = suit;
            this.Value = value;
        }

        public override string ToString() {
            return Name;
        }

        public static bool DoesCardMatch(Card cardToCheck, Suits suit) {
            if (cardToCheck.Suit == suit)
                return true;
            else
                return false;
        }

        public static bool DoesCardMatch(Card cardToCheck, Values value) {
            if (cardToCheck.Value == value)
                return true;
            else
                return false;
        }
    }
}
