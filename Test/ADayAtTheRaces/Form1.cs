using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public partial class Form1 : Form
    {
        Random MyRandomizer = new Random();
        Greyhound[] GreyhoundArray = new Greyhound[4];
        Guy[] ThreeGuys = new Guy[3];
        public Form1()
        {
            InitializeComponent();
            minimumBetLabel.Text = "Minimum bet: $" + numericUpDown1.Minimum;
            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = pictureBoxDog1,
                StartingPosition = pictureBoxDog1.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBoxDog1.Width,
                Randomizer = MyRandomizer
            };
            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = pictureBoxDog2,
                StartingPosition = pictureBoxDog2.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBoxDog2.Width,
                Randomizer = MyRandomizer
            };
            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = pictureBoxDog3,
                StartingPosition = pictureBoxDog3.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBoxDog3.Width,
                Randomizer = MyRandomizer
            };
            GreyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = pictureBoxDog4,
                StartingPosition = pictureBoxDog4.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBoxDog4.Width,
                Randomizer = MyRandomizer
            };
            ThreeGuys[0] = new Guy()
            {
                Name = "Joe",
                Cash = 50,
                MyRadioButton = joeRadioButton,
                MyLabel = joeBetLabel
            };
            ThreeGuys[1] = new Guy()
            {
                Name = "Bob",
                Cash = 75,
                MyRadioButton = bobRadioButton,
                MyLabel = bobBetLabel
            };
            ThreeGuys[2] = new Guy()
            {
                Name = "Al",
                Cash = 45,
                MyRadioButton = alRadioButton,
                MyLabel = alBetLabel
            };
            for(int i =0;i<3;i++)
            {
                ThreeGuys[i].PlaceBet(0, 0);
                ThreeGuys[i].UpdateLabels();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i=0;i<4;i++)
            {
                if (GreyhoundArray[i].Run())
                {
                    timer1.Stop();
                    MessageBox.Show("Dog #" + (i + 1) + " won the race!", "We have a winner");
                    for(int k=0;k<4;k++)
                    {
                        GreyhoundArray[k].TakeStartingPosition();
                    }
                    groupBox1.Enabled = true;
                    for(int j = 0; j < 3; j++)
                    {
                        ThreeGuys[j].Collect(i+1);
                    }
                    break;
                }
            }
        }

        private void betsButton_Click(object sender, EventArgs e)
        {
            for(int i=0;i<3;i++)
            {
                if(ThreeGuys[i].MyRadioButton.Checked)
                {
                    if(ThreeGuys[i].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value))
                    {
                        ThreeGuys[i].UpdateLabels();
                    }
                    break;
                }
            }
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            groupBox1.Enabled = false;
        }
    }
}
