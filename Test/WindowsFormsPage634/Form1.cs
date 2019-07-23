using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPage634 {
    public partial class Form1 : Form {
        Random random = new Random();

        public Form1() {
            InitializeComponent();
        }

        public int ReturnThreeValues(out double half, out int twice) {
            int value = random.Next(1000);
            half = ((double)value) / 2;
            twice = value * 2;
            return value;
        }

        private void button1_Click(object sender, EventArgs e) {
            int a;
            double b;
            int c;
            a = ReturnThreeValues(out b, out c);
            Console.WriteLine("Value = {0}, half = {1}, double = {2}", a, b, c);
        }

        public void ModifyAnIntButton(ref int value, ref Button button) {
            int i = value;
            i *= 5;
            value = i - 3;
            button = button1;
        }

        private void button2_Click(object sender, EventArgs e) {
            int q = 100;
            Button b = button1;
            ModifyAnIntButton(ref q, ref b);
            Console.WriteLine("q = {0}, b.Text = {1}", q, b.Text);
        }

        void CheckTemperature(double temperature, double tooHigh = 37.5, double tooLow = 36) {
            if (temperature < tooHigh && temperature > tooLow)
                Console.WriteLine("Feeling Good!");
            else
                Console.WriteLine("Uh-oh -- better see a doctor!");
        }

        private void button3_Click(object sender, EventArgs e) {
            CheckTemperature(37.9);

            CheckTemperature(37.9, 38, 37);

            CheckTemperature(35.9, tooLow: 35.5);
        }
    }
}
