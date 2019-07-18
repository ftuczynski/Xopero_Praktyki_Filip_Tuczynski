using System.Windows;
using System.Windows.Input;

namespace Wpf_GoFish {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        Game game;
        public MainWindow() {
            InitializeComponent();
            game = this.FindResource("game") as Game;
        }

        private void startButton_Click(object sender, RoutedEventArgs e) {
            game.StartGame();
        }

        private void askForACard_Click(object sender, RoutedEventArgs e) {
            if (cards.SelectedIndex >= 0)
                game.PlayOneRound(cards.SelectedIndex);
        }

        private void cards_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            if (cards.SelectedIndex >= 0)
                game.PlayOneRound(cards.SelectedIndex);
        }
    }
}
