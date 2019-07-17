using System;
using System.Collections.Generic;

namespace ConsolePage497 {
    [Serializable]
    class Deck {
        private List<Card> cards;
        private Random random = new Random();
        public int Count {
            get {
                return cards.Count;
            }
        }

        public Deck() {
            cards = new List<Card>();
            for (int suit = 0; suit < 4; suit++)
                for (int value = 1; value < 14; value++)
                    cards.Add(new Card((Suits)suit, (Values)value));
        }

        public Deck(IEnumerable<Card> initialCard) {
            cards = new List<Card>(initialCard);
        }

        public void Add(Card cardToAdd) {
            cards.Add(cardToAdd);
        }

        public Card Peek(int cardNumber) {
            return cards[cardNumber];
        }

        public bool ContainsValue(Values value) {
            foreach (Card card in cards)
                if (card.Value == value)
                    return true;
            return false;
        }

        public Deck PullOutValues(Values value) {
            Deck deckToReturn = new Deck(new Card[] { });
            for (int i = cards.Count - 1; i >= 0; i--)
                if (cards[i].Value == value)
                    deckToReturn.Add(Deal(i));
            return deckToReturn;
        }

        public bool HasBook(Values value) {
            int NumberOfCards = 0;
            foreach (Card card in cards)
                if (card.Value == value)
                    NumberOfCards++;
            if (NumberOfCards == 4)
                return true;
            else
                return false;
        }

        public Card Deal(int index) {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
        }

        public Card Deal() {
            return Deal(0);
        }

        public void Shuffle() {
            List<Card> newCards = new List<Card>();
            while (cards.Count > 0) {
                int CardToMove = random.Next(cards.Count);
                newCards.Add(cards[CardToMove]);
                cards.RemoveAt(CardToMove);
            }
            cards = newCards;
        }

        public IEnumerable<string> GetCardNames() {
            string[] CardNames = new string[cards.Count];
            for (int i = 0; i < cards.Count; i++)
                CardNames[i] = cards[i].Name;
            return CardNames;
        }

        public void Sort() {
            cards.Sort(new CardComparer_bySuit());
        }

        public void SortByValue() {
            cards.Sort(new CardComparer_byValue());
        }
    }
}
