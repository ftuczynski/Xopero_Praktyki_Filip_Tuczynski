﻿using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Wpf_GoFish {
    class Game : INotifyPropertyChanged {
        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;
        public bool GameInProgress { get; private set; }
        public bool GameNotStarted { get { return !GameInProgress; } }
        public string PlayerName { get; set; }
        public ObservableCollection<string> Hand { get; private set; }
        public string Books { get { return DescribeBooks(); } }
        public string GameProgress { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Game() {
            PlayerName = "Ed";
            Hand = new ObservableCollection<string>();
            ResetGame();
        }
        public void AddProgress(string progress) {
            GameProgress = progress + Environment.NewLine + GameProgress;
            OnPropertyChanged("GameProgress");
        }
        public void ClearProgress() {
            GameProgress = String.Empty;
            OnPropertyChanged("GameProgress");
        }
        public void StartGame() {
            ClearProgress();
            GameInProgress = true;
            OnPropertyChanged("GameInProgress");
            OnPropertyChanged("GameNotStarted");
            Random random = new Random();
            players = new List<Player>();
            players.Add(new Player(PlayerName, random, this));
            players.Add(new Player("Bob", random, this));
            players.Add(new Player("Joe", random, this));
            Deal();
            players[0].SortHand();
            Hand.Clear();
            foreach (String cardName in GetPlayerCardNames())
                Hand.Add(cardName);
            if (!GameInProgress)
                AddProgress(DescribePlayerHands());
            OnPropertyChanged("Books");
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

        public void PlayOneRound(int selectedPlayerCard) {
            Values value = players[0].Peek(selectedPlayerCard).Value;

            for (int i = 0; i < players.Count; i++) {
                if (i == 0)
                    players[0].AskForACard(players, 0, stock, value);
                else
                    players[i].AskForACard(players, i, stock);
                if (PullOutBooks(players[i])) {
                    AddProgress(players[i].Name + " drew a new hand" + Environment.NewLine);
                    int card = 1;
                    while (card <= 5 && stock.Count > 0) {
                        players[i].TakeCard(stock.Deal());
                        card++;
                    }
                }
                OnPropertyChanged("Books");
                if (stock.Count == 0) {
                    AddProgress("The stock is out of cards. Game over!");
                    AddProgress("The winner is... " + GetWinnerName());
                    ResetGame();
                    return;
                }
            }
            Hand.Clear();
            players[0].SortHand();
            foreach (String cardName in GetPlayerCardNames())
                Hand.Add(cardName);
            if (!GameInProgress)
                AddProgress(DescribePlayerHands());
        }

        public void ResetGame() {
            GameInProgress = false;
            OnPropertyChanged("GameInProgress");
            OnPropertyChanged("GameNotStarted");
            books = new Dictionary<Values, Player>();
            stock = new Deck();
            Hand.Clear();
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
