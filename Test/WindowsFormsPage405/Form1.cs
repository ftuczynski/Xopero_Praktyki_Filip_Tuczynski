using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsPage405 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();

        private void addFlapjacks_Click(object sender, EventArgs e) {
            Flapjack food;
            if (crispy.Checked)
                food = Flapjack.Crispy;
            if (soggy.Checked)
                food = Flapjack.Soggy;
            if (browned.Checked)
                food = Flapjack.Browned;
            else
                food = Flapjack.Banana;
            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);
            RedrawList();
        }

        private void nextLumberjack_Click(object sender, EventArgs e) {
            if (breakfastLine.Count == 0) return;
            Lumberjack nextLumberjack = breakfastLine.Dequeue();
            nextLumberjack.EatFlapjacks();
            nextInLine.Text = "";
            RedrawList();
        }

        private void addLumberjack_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(textLumberjackName.Text)) return;
            breakfastLine.Enqueue(new Lumberjack(textLumberjackName.Text));
            nextInLine.Text = "";
            RedrawList();
        }

        private void RedrawList() {
            int number = 1;
            line.Items.Clear();
            foreach(Lumberjack jack in breakfastLine) {
                line.Items.Add(number + ". " + jack.Name);
                number++;
            }
            if (breakfastLine.Count == 0) {
                groupBox1.Enabled = false;
                nextInLine.Text = "";
            }
            else {
                groupBox1.Enabled = true;
                Lumberjack currentLumberjack = breakfastLine.Peek();
                nextInLine.Text = currentLumberjack.Name + " has " + currentLumberjack.FlapjackCount + " flapjacks";
            }
        }
    }
}
