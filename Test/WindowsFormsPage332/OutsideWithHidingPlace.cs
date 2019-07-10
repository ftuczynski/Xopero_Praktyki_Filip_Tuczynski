using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPage332 {
    class OutsideWithHidingPlace : Outside, IHidingPlace {
        public string NameOfTheHiddingPlace { get; private set; }

        public OutsideWithHidingPlace(string nameOfTheHiddingPlace, string name, bool hot)
            : base(name, hot) {
            this.NameOfTheHiddingPlace = nameOfTheHiddingPlace;
        }
        public override string Description {
            get {
                return base.Description + "Someone could hide " + NameOfTheHiddingPlace + ". ";
            }
        }
    }
}
