using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePage299 {
    class Bee : IStingPatrol {
        public int AlertLevel { get; }

        public int StingerLength { get; }

        public bool LookForEnemies() {
            return true;
        }

        public int SharpenStinger(int lenght) {
            return 0;
        }
    }
}
