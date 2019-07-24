using System.Windows;

namespace WpfPage710 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        BaseballSimulator baseballSimulator;
        public MainWindow() {
            InitializeComponent();
            baseballSimulator = FindResource("baseballSimulator") as BaseballSimulator;
        }
        private void Button_Click(object sender, RoutedEventArgs e) {
            baseballSimulator.PlayBall();
        }
    }
}
