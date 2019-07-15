using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace GoFish {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private Game game;

        private void buttonStart_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(textName.Text)) {
                MessageBox.Show("Please enter your name", "Can't start the game yet");
                return;
            }
            game = new Game(textName.Text, new List<string> { "Joe", "Bob" }, textProgress);
            buttonStart.Enabled = false;
            textName.Enabled = false;
            buttonAsk.Enabled = true;
            UpdateForm();
        }

        private void UpdateForm() {
            listHand.Items.Clear();
            foreach (string cardName in game.GetPlayerCardNames())
                listHand.Items.Add(cardName);
            textBooks.Text = game.DescribeBooks();
            textBooks.ScrollToCaret();
            textProgress.Text += game.DescribePlayerHands();
            textProgress.SelectionStart = textProgress.Text.Length;
            textProgress.ScrollToCaret();
        }

        private void buttonAsk_Click(object sender, EventArgs e) {
            textProgress.Text = "";
            if (listHand.SelectedIndex < 0) {
                MessageBox.Show("Please select a card");
                return;
            }
            if (game.PlayOneRound(listHand.SelectedIndex)) {
                textProgress.Text += "The winner is... " + game.GetWinnerName();
                textBooks.Text = game.DescribeBooks();
                textBooks.ScrollToCaret();
                buttonAsk.Enabled = false;
            }
            else
                UpdateForm();
        }
    }
}
