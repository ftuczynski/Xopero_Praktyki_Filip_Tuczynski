using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePage375 {
    class CardComparer_byValue : IComparer<Card> {
        public int Compare(Card x, Card y) {
            if (x.Value > y.Value)
                return 1;
            else if (x.Value < y.Value)
                return -1;
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
    }
}
