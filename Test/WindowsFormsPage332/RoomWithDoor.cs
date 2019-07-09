using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPage332 {
    class RoomWithDoor : Room, IHasExteriorDoor {
        public string DoorDescription { get; }
        public Location DoorLocation { get; }

        public RoomWithDoor(string name, string decoration, string doorDescription)
            : base(name, decoration) {
            this.DoorDescription = doorDescription;
        }
    }
}
