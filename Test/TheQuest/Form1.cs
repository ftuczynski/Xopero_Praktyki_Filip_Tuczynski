using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheQuest {
    public partial class Form1 : Form {
        private Game game;
        private Random random = new Random();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            game = new Game(new Rectangle(78, 57, 520, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }

        private void UpdateCharacters() {
            playerBox.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            foreach(Enemy enemy in game.Enemies) {
                if(enemy is Bat) {
                    batBox.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0) {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                else if (enemy is Ghost) {
                    ghostBox.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0) {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                else if (enemy is Ghoul) {
                    ghoulBox.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0) {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }
            if (!showBat) {
                batBox.Visible = false;
                batHitPoints.Text = "";
            }
            else
                batBox.Visible = true;
            if (!showGhost) {
                ghostBox.Visible = false;
                ghostHitPoints.Text = "";
            }
            else
                ghostBox.Visible = true;
            if (!showGhoul) {
                ghoulBox.Visible = false;
                ghoulHitPoints.Text = "";
            }
            else
                ghoulBox.Visible = true;

            swordBox.Visible = false;
            bowBox.Visible = false;
            maceBox.Visible = false;
            potionBlueBox.Visible = false;
            potionRedBox.Visible = false;
            Control weaponControl = null;
            switch (game.WeaponInRoom.Name) {
                case "Sword":
                    weaponControl = swordBox;
                    break;
                case "Bow":
                    weaponControl = bowBox;
                    break;
                case "Mace":
                    weaponControl = maceBox;
                    break;
                case "Blue Potion":
                    weaponControl = potionBlueBox;
                    break;
                case "Red Potion":
                    weaponControl = potionRedBox;
                    break;
            }
            weaponControl.Visible = true;

            if (game.CheckPlayerInventory("Sword"))
                swordBigBox.Visible = true;
            else
                swordBigBox.Visible = false;
            if (game.CheckPlayerInventory("Bow"))
                bowBigBox.Visible = true;
            else
                bowBigBox.Visible = false;
            if (game.CheckPlayerInventory("Mace"))
                maceBigBox.Visible = true;
            else
                maceBigBox.Visible = false;
            if (game.CheckPlayerInventory("Blue Potion"))
                potionBlueBigBox.Visible = true;
            else
                potionBlueBigBox.Visible = false;
            if (game.CheckPlayerInventory("Red Potion"))
                potionRedBigBox.Visible = true;
            else
                potionRedBigBox.Visible = false;

            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
                weaponControl.Visible = true;
            if (game.PlayerHitPoints <= 0) {
                MessageBox.Show("You died");
                Application.Exit();
            }
            if (enemiesShown < 1) {
                MessageBox.Show("You have defeated the enemies on this level");
                game.NewLevel(random);
                UpdateCharacters();
            }
        }

        private void HideBorderStyle() {
            swordBigBox.BorderStyle = BorderStyle.None;
            bowBigBox.BorderStyle = BorderStyle.None;
            maceBigBox.BorderStyle = BorderStyle.None;
            potionBlueBigBox.BorderStyle = BorderStyle.None;
            potionRedBigBox.BorderStyle = BorderStyle.None;
        }

        private void ShowArrows(bool show) {
            if (!show) {
                attackLeftButton.Visible = false;
                attackDownButton.Visible = false;
                attackRightButton.Visible = false;
                attackUpButton.Text = "*";
                groupBox2.Text = "Drink";
            }
            else {
                attackLeftButton.Visible = true;
                attackDownButton.Visible = true;
                attackRightButton.Visible = true;
                attackUpButton.Text = "↑";
                groupBox2.Text = "Attack";
            }
        }

        private void swordBigBox_Click(object sender, EventArgs e) {
            if (game.CheckPlayerInventory("Sword")) {
                game.Equip("Sword");
                HideBorderStyle();
                swordBigBox.BorderStyle = BorderStyle.Fixed3D;
                ShowArrows(true);
            }
        }

        private void bowBigBox_Click(object sender, EventArgs e) {
            if (game.CheckPlayerInventory("Bow")) {
                game.Equip("Bow");
                HideBorderStyle();
                bowBigBox.BorderStyle = BorderStyle.Fixed3D;
                ShowArrows(true);
            }
        }

        private void maceBigBox_Click(object sender, EventArgs e) {
            if (game.CheckPlayerInventory("Mace")) {
                game.Equip("Mace");
                HideBorderStyle();
                maceBigBox.BorderStyle = BorderStyle.Fixed3D;
                ShowArrows(true);
            }
        }

        private void potionBlueBigBox_Click(object sender, EventArgs e) {
            if (game.CheckPlayerInventory("Blue Potion")) {
                game.Equip("Blue Potion");
                HideBorderStyle();
                potionBlueBigBox.BorderStyle = BorderStyle.Fixed3D;
                ShowArrows(false);
            }
        }

        private void potionRedBigBox_Click(object sender, EventArgs e) {
            if (game.CheckPlayerInventory("Red Potion")) {
                game.Equip("Red Potion");
                HideBorderStyle();
                potionRedBigBox.BorderStyle = BorderStyle.Fixed3D;
                ShowArrows(false);
            }
        }

        private void moveUpButton_Click(object sender, EventArgs e) {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void moveLeftButton_Click(object sender, EventArgs e) {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void moveDownButton_Click(object sender, EventArgs e) {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void moveRightButton_Click(object sender, EventArgs e) {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void attackUpButton_Click(object sender, EventArgs e) {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void attackLeftButton_Click(object sender, EventArgs e) {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void attackDownButton_Click(object sender, EventArgs e) {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void attackRightButton_Click(object sender, EventArgs e) {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }
    }
}
