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
        public Form1() {
            InitializeComponent();
            CreateObjects();
        }

        public void CreateObjects() {
            RoomWithDoor livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob");
            Room diningRoom = new Room("Dining Room", "a crystal chandelier");
            RoomWithDoor kitchen = new RoomWithDoor("Kitchen", "a stainless steel appliances", "a screen door");
        }
    }
}
