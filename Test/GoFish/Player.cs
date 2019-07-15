using System;
using System.Collections.Generic;
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
            this.cards = new Deck(new Card[] { });
            this.textBoxOnForm.Text += this.name + " has just joined the game" + Environment.NewLine;
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
            Deck deckToReturn = cards.PullOutValues(value);
            textBoxOnForm.Text += Name + " has " + deckToReturn.Count.ToString() + " " + Card.Plural(value) + Environment.NewLine;
            return deckToReturn;
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock) {
            if (stock.Count > 0) {
                if (cards.Count == 0) {
                    cards.Add(stock.Deal());
                }
                AskForACard(players, myIndex, stock, GetRandomValue());
            }
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value) {
            textBoxOnForm.Text += Name + " asks if anyone has a " + value.ToString() + "." + Environment.NewLine;
            int j = 0;
            for (int i = 0; i < players.Count; i++) {
                if (i != myIndex) {
                    Player player = players[i];
                    Deck CardsGiven = player.DoYouHaveAny(value);
                    j += CardsGiven.Count;
                    while (CardsGiven.Count > 0) {
                        cards.Add(CardsGiven.Deal());
                    }
                }
            }
            if (j == 0 && stock.Count > 0) {
                cards.Add(stock.Deal());
                textBoxOnForm.Text += Name + " had to draw from the stock" + Environment.NewLine;
            }
        }

    }
}
