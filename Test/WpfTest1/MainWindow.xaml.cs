using System.Windows;
using System;

namespace WpfTest1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            string name = "Quentin";
            int x = 3;
            x *= 17;
            double d = Math.PI / 2;
            myLabel.Text = "nazwa to " + name + "\nx jest równe " + x + "\nd jest równe " + d;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 5;
            if(x==10)
            {
                myLabel.Text = "x musi być równe 10";
            }
            else
            {
                myLabel.Text = "x nie jest równe 10";
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 4;
            string name = "Filip";
            if ((someValue == 3) && (name.Equals("Janek")))
            {
                myLabel.Text = "someValue jest równe 3 i name jest równe Janek";
            }
            myLabel.Text = "ten wiersz jest wykonywany bez względu na warunki";
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            while (count<10)
            {
                count++;
            }
            for (int i=0;i<5;i++)
            {
                count--;
            }
            myLabel.Text = "odpowiedź brzmi: " + count;
        }
    }
}
