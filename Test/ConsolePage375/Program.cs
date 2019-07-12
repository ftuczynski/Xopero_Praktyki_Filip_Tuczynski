using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePage375 {
    class Program {
        static void Main(string[] args) {
            List<Card> cards = new List<Card> {
                new Card(Suits.Diamonds,Values.Ten),
                new Card(Suits.Spades,Values.Queen),
                new Card(Suits.Hearts,Values.Seven),
                new Card(Suits.Hearts,Values.Jack),
                new Card(Suits.Diamonds,Values.Queen)
            };
            CardComparer_byValue cardComparer = new CardComparer_byValue();
            Console.WriteLine("Five random cards: ");
            ReadCards(cards);
            cards.Sort(cardComparer);
            Console.WriteLine("\nThose same card, sorted: ");
            ReadCards(cards);

            Console.ReadKey();
        }

        public static void ReadCards(List<Card> cards) {
            foreach(Card card in cards) {
                Console.WriteLine(card);
            }
        }
    }
}
