using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_GoFish {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        Game game;
        public MainWindow() {
            InitializeComponent();
        }

        //private void UpdateForm() {
        //    listHand.Items.Clear();
        //    foreach (string cardName in game.GetPlayerCardNames())
        //        listHand.Items.Add(cardName);
        //    scrollBooks.Content = game.DescribeBooks();
        //    scrollBooks.ScrollToBottom();
        //    scrollProgress.Content+= game.DescribePlayerHands();
        //    //scrollProgress.SelectionStart = textProgress.Text.Length;
        //    scrollProgress.ScrollToBottom();
        //}

        //private void StartButton_Click(object sender, RoutedEventArgs e) {
        //    if (String.IsNullOrEmpty(playerName.Text)) {
        //        MessageBox.Show("Please enter your name", "Can't start the game yet");
        //        return;
        //    }
        //    game = new Game(playerName.Text, new List<string> { "Joe", "Bob" }, scrollProgress);
        //    startButton.IsEnabled = false;
        //    playerName.IsEnabled = false;
        //    buttonAsk.Enabled = true;
        //    UpdateForm();
        //}

        //private void AskForACard_Click(object sender, RoutedEventArgs e) {
        //    textProgress.Text = "";
        //    if (listHand.SelectedIndex < 0) {
        //        MessageBox.Show("Please select a card");
        //        return;
        //    }
        //    if (game.PlayOneRound(listHand.SelectedIndex)) {
        //        textProgress.Text += "The winner is... " + game.GetWinnerName();
        //        textBooks.Text = game.DescribeBooks();
        //        textBooks.ScrollToCaret();
        //        buttonAsk.Enabled = false;
        //    }
        //    else
        //        UpdateForm();
        //}
    }
}
