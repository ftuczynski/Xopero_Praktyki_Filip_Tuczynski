using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPage332 {
    class RoomWithHidingPlace : Room, IHidingPlace {
        public string NameOfTheHiddingPlace { get; private set; }
        
        public RoomWithHidingPlace(string nameOfTheHiddingPlace,string name,string decoration)
            :base(name,decoration) {
            this.NameOfTheHiddingPlace = nameOfTheHiddingPlace;
        }
        public override string Description {
            get {
                return base.Description + "Someone could hide " + NameOfTheHiddingPlace + ". ";
            }
        }
    }
}
