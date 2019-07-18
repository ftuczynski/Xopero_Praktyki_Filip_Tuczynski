using System.Windows;

namespace Wpf_SloppyJoes {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
        }

        private void newMenu_Click(object sender, RoutedEventArgs e) {
            MenuMaker menuMaker = FindResource("menuMaker") as MenuMaker;
            menuMaker.UpdateMenu();
        }
    }
}
