using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPage332 {
    class RoomWithDoor : Room, IHasExteriorDoor {
        public string DoorDescription { get; private set; }
        public Location DoorLocation { get; set; }
        public override string Description {
            get {
                return base.Description + " You see " + DoorDescription + ". ";
            }
        }

        public RoomWithDoor(string name, string decoration, string doorDescription)
            : base(name, decoration) {
            this.DoorDescription = doorDescription;
        }
    }
}
