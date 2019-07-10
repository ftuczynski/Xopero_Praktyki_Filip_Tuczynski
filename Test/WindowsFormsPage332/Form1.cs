using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPage332 {
    public partial class Form1 : Form {
        int moves;
        Location currentLocation;
        Opponent opponent;
        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;
        Room stairs;
        RoomWithHidingPlace upstairsHallway;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;
        RoomWithHidingPlace bathroom;
        OutsideWithDoor frontYard;
        OutsideWithHidingPlace garden;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace driveway;

        public Form1() {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        }

        private void CreateObjects() {
            livingRoom = new RoomWithDoor("under the sofa", "Living Room", "an antique carpet", "an oak door with a brass knob");
            diningRoom = new Room("Dining Room", "a crystal chandelier");
            kitchen = new RoomWithDoor("in the fridge","Kitchen", "a stainless steel appliances", "a screen door");
            stairs = new Room("Stairs", "wooden bannister");
            upstairsHallway = new RoomWithHidingPlace("in the closet", "Upstairs Hallway", "picture of a dog");
            masterBedroom = new RoomWithHidingPlace("under the bed", "Master Bedroom", "large bed");
            secondBedroom = new RoomWithHidingPlace("under the bed", "Second Bedroom", "small bed");
            bathroom = new RoomWithHidingPlace("in the shower", "Bathroom", "sink and a toilet");
            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            garden = new OutsideWithHidingPlace("in the shed", "Garden", false);
            backYard = new OutsideWithDoor("Back Yard", true, "a screen door");
            driveway = new OutsideWithHidingPlace("in the garage", "Driveway", false);

            livingRoom.Exits = new Location[] { diningRoom, stairs };
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            kitchen.Exits = new Location[] { diningRoom };
            stairs.Exits = new Location[] { livingRoom, upstairsHallway };
            upstairsHallway.Exits = new Location[] { masterBedroom, secondBedroom, bathroom };
            masterBedroom.Exits = new Location[] { upstairsHallway };
            secondBedroom.Exits = new Location[] { upstairsHallway };
            bathroom.Exits = new Location[] { upstairsHallway };
            frontYard.Exits = new Location[] { garden, backYard, driveway };
            garden.Exits = new Location[] { frontYard, backYard };
            backYard.Exits = new Location[] { frontYard, garden, driveway };
            driveway.Exits = new Location[] { frontYard, backYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;

            ResetGame(false);
        }

        private void MoveToANewLocation(Location newLocation) {
            moves++;
            currentLocation = newLocation;
            RedrawForm();
        }

        private void goHere_Click(object sender, EventArgs e) {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e) {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }

        private void RedrawForm() {
            exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++) {
                exits.Items.Add(currentLocation.Exits[i].Name);
            }
            exits.SelectedIndex = 0;

            description.Text = currentLocation.Description + "\r\n (move #" + moves + ")";

            if (currentLocation is IHasExteriorDoor)
                goThroughTheDoor.Visible = true;
            else
                goThroughTheDoor.Visible = false;

            if (currentLocation is IHidingPlace) {
                IHidingPlace isHidingPlace = currentLocation as IHidingPlace;
                checkButton.Text = "Check " + isHidingPlace.NameOfTheHiddingPlace + ".";
                checkButton.Visible = true;
            }
            else
                checkButton.Visible = false;
        }

        private void ResetGame(bool displayMessage) {
            if (displayMessage) {
                MessageBox.Show("You found me in " + moves + " moves!", "Wow!");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                description.Text = "You found your opponent in " + moves + " moves! He was hiding "
                    + foundLocation.NameOfTheHiddingPlace + ".";
            }
            moves = 0;
            hideButton.Visible = true;
            goHere.Visible = false;
            checkButton.Visible = false;
            goThroughTheDoor.Visible = false;
            exits.Visible = false;
        }

        private void checkButton_Click(object sender, EventArgs e) {
            moves++;
            if(opponent.Check(currentLocation)) {
                ResetGame(true);
            }
            else {
                description.Text = "There is no one here! ";
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
                RedrawForm();
            }
        }

        private void hideButton_Click(object sender, EventArgs e) {
            hideButton.Visible = false;
            for (int i = 1; i <= 10; i++) {
                description.Text = i + "... ";
                opponent.Move();
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
            description.Text = "Ready or not, here I come! ";
            Application.DoEvents();
            System.Threading.Thread.Sleep(1000);

            goHere.Visible = true;
            exits.Visible = true;
            MoveToANewLocation(livingRoom);
        }
    }
}
