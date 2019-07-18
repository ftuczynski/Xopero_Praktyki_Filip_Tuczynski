using System;
using System.Collections.Generic;

namespace Wpf_GoFish {
    class Player {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        public int CardCount { get { return cards.Count; } }
        private Game game;

        public Player(String name, Random random, Game game) {
            this.name = name;
            this.random = random;
            this.game = game;
            this.cards = new Deck(new Card[] { });
            game.AddProgress(name + " has just joined the game");
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
            game.AddProgress(Name + " has " + deckToReturn.Count.ToString() + " " + Card.Plural(value));
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
            game.AddProgress(Name + " asks if anyone has a " + value + ".");
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
                game.AddProgress(Name + " had to draw from the stock.");
            }
        }

    }
}
