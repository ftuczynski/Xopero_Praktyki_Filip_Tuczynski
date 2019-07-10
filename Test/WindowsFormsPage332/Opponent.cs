using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPage332 {
    class Opponent {
        private Location myLocation;
        private Random random;

        public Opponent(Location startingLocation) {
            this.myLocation = startingLocation;
            this.random = new Random();
        }

        public void Move() {
            do {
                if (myLocation is IHasExteriorDoor && random.Next(2) == 1) {
                    IHasExteriorDoor hasDoor = myLocation as IHasExteriorDoor;
                    myLocation = hasDoor.DoorLocation;
                }
                else {
                    myLocation = myLocation.Exits[random.Next(myLocation.Exits.Length)];
                }
            } while ((myLocation is IHidingPlace) == false);
        }
        public bool Check(Location location) {
            if (location == this.myLocation)
                return true;
            else
                return false;
        }
    }
}
