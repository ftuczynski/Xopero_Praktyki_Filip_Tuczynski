using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish {
    class Player {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;
        public int CardCount { get { return cards.Count; } }

        public Player(String name, Random random, TextBox textBoxOnForm) {
            this.name = name;
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;
            this.textBoxOnForm.Text += this.name + " has just joined the game \r\n";
        }

        public void TakeCard(Card card) {
            cards.Add(card);
        }

        public IEnumerable<string> GetCardNames() {
            return cards.GetCardNames();
        }

        public Card Peek(int cardNumber) {
            return cards.Peek(cardNumber);
        }

        public void SortHand() {
            cards.SortByValue();
        }

        public IEnumerable<Values> PullOutBooks() {
            List<Values> books = new List<Values>();
            for (int i = 1; i <= 13; i++) {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++) {
                    if (cards.Peek(card).Value == value)
                        howMany++;
                }
                if (howMany == 4) {
                    books.Add(value);
                    cards.PullOutValues(value);
                }
            }
            return books;
        }

        public Values GetRandomValue() {
            return cards.Peek(random.Next(cards.Count)).Value;
        }

        public Deck DoYouHaveAny(Values value) {
            Deck deckToReturn = new Deck(new Card[] { });
            deckToReturn = cards.PullOutValues(value);
            textBoxOnForm.Text += Name + " has " + deckToReturn.Count.ToString() + " " + Card.Plural(value) + "\r\n";
            return deckToReturn;
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock) {
            // Here's an overloaded version of AskForACard()—choose a random value
            // from the deck using GetRandomValue() and ask for it using AskForACard()
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value) {
            // Ask the other players for a value. First add a line to the TextBox: "Joe asks
            // if anyone has a Queen". Then go through the list of players that was passed in
            // as a parameter and ask each player if he has any of the value (using his
            // DoYouHaveAny() method). He'll pass you a deck of cards—add them to my deck.
            // Keep track of how many cards were added. If there weren't any, you'll need
            // to deal yourself a card from the stock (which was also passed as a parameter),
            // and you'll have to add a line to the TextBox: "Joe had to draw from the stock"
            textBoxOnForm.Text += Name + " asks if anyone has a " + value.ToString() + ". \r\n";
            foreach (Player player in players) {

            }
        }

    }
}
