using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPage163
{
    public partial class Form1 : Form
    {
        Elephant lucinda;
        Elephant lloyd;

        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
        }

        //Lloyd button
        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        //Lucinda button
        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        //swap button
        private void button3_Click(object sender, EventArgs e)
        {
            Elephant holder;
            holder = lucinda;
            lucinda = lloyd;
            lloyd = holder;
            MessageBox.Show("Swapped!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lloyd = lucinda;
            lloyd.EarSize = 4321;
            lloyd.WhoAmI();
        }
    }
}
