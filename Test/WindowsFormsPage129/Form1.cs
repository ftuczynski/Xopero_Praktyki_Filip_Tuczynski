using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPage129
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " has $" + joe.Cash;
            bobsCashLabel.Text = bob.Name + " has $" + bob.Cash;
            bankCashLabel.Text = "The bank has $" + bank;
        }
        public Form1()
        {
            InitializeComponent();

            joe = new Guy() { Cash = 50, Name = "Joe" };

            bob = new Guy() { Cash = 100, Name = "Bob" };

            UpdateForm();
        }

        //Give $10 to Joe
        private void button1_Click(object sender, EventArgs e)
        {
            if(bank >=10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money.");
            }
        }

        //Receive $5 from Bob
        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        //Joe gives $10 to Bob
        private void button3_Click(object sender, EventArgs e)
        {
            bob.ReceiveCash(joe.GiveCash(10));
            UpdateForm();
        }

        //Bob gives $5 to Joe
        private void button4_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash(bob.GiveCash(5));
            UpdateForm();
        }
    }
}
