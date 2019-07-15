using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace GoFish {
    class Game {
        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;
        private TextBox textBoxOnForm;

        public Game(string playerName, IEnumerable<string> opponentNames, TextBox textBoxOnForm) {
            Random random = new Random();
            this.textBoxOnForm = textBoxOnForm;
            players = new List<Player>();
            players.Add(new Player(playerName, random, textBoxOnForm));
            foreach (string player in opponentNames) {
                players.Add(new Player(player, random, textBoxOnForm));
            }
            books = new Dictionary<Values, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();

        }

        private void Deal() {
            stock.Shuffle();
            foreach (Player player in players) {
                for (int i = 0; i < 5; i++) {
                    player.TakeCard(stock.Deal());
                }
            }
            foreach (Player player in players) {
                PullOutBooks(player);
            }
        }

        public bool PlayOneRound(int selectedPlayerCard) {
            Values value = players[0].Peek(selectedPlayerCard).Value;

            for (int i = 0; i < players.Count; i++) {
                if (i == 0)
                    players[0].AskForACard(players, 0, stock, value);
                else
                    players[i].AskForACard(players, i, stock);
                if (PullOutBooks(players[i])) {
                    textBoxOnForm.Text += players[i].Name + " drew a new hand" + Environment.NewLine;
                    int card = 1;
                    while (card <= 5 && stock.Count > 0) {
                        players[i].TakeCard(stock.Deal());
                        card++;
                    }
                }
                players[0].SortHand();
                if (stock.Count == 0) {
                    textBoxOnForm.Text = "The stock is out of cards. Game over!" + Environment.NewLine;
                    return true;
                }
            }
            return false;
        }

        public bool PullOutBooks(Player player) {
            foreach (Values value in player.PullOutBooks()) {
                books.Add(value, player);
            }
            if (player.CardCount == 0)
                return true;
            return false;
        }

        public string DescribeBooks() {
            string description = "";
            foreach (Values value in books.Keys) {
                description += books[value].Name + " has a book of " + Card.Plural(value) + "." + Environment.NewLine;
            }
            return description;
        }

        public string GetWinnerName() {
            Dictionary<string, int> winners = new Dictionary<string, int>();
            foreach (Values value in books.Keys) {
                string name = books[value].Name;
                if (winners.ContainsKey(name))
                    winners[name]++;
                else
                    winners.Add(name, 1);
            }
            int mostBooks = 0;
            foreach (string name in winners.Keys)
                if (winners[name] > mostBooks)
                    mostBooks = winners[name];
            bool tie = false;
            string winnerList = "";
            foreach (string name in winners.Keys)
                if (winners[name] == mostBooks) {
                    if (!String.IsNullOrEmpty(winnerList)) {
                        winnerList += " and ";
                        tie = true;
                    }
                    winnerList += name;
                }
            winnerList += " with " + mostBooks + " books";
            if (tie)
                return "A tie between " + winnerList;
            else
                return winnerList;
        }

        public IEnumerable<string> GetPlayerCardNames() {
            return players[0].GetCardNames();
        }

        public string DescribePlayerHands() {
            string description = "";
            for (int i = 0; i < players.Count; i++) {
                description += players[i].Name + " has " + players[i].CardCount;
                if (players[i].CardCount == 1)
                    description += " card." + Environment.NewLine;
                else
                    description += " cards." + Environment.NewLine;
            }
            description += "The stock has " + stock.Count + " cards left.";
            return description;
        }
    }
}
