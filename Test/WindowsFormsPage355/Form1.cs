using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPage355 {
    public partial class Form1 : Form {

        Random random = new Random();

        public Form1() {
            InitializeComponent();
        }

        private void randomButton_Click(object sender, EventArgs e) {
            Card card = new Card((Suits)random.Next(4), (Values)random.Next(1, 14));
            MessageBox.Show(card.Name);
        }
    }
}
