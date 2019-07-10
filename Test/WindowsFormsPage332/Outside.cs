using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPage332 {
    class Outside : Location {
        private bool hot;
        public override string Description {
            get {
                if (this.hot)
                    return base.Description + " It's very hot here. ";
                else
                    return base.Description;
            }
        }

        public Outside(string name, bool hot)
            : base(name) {
            this.hot = hot;
        }
    }
}
