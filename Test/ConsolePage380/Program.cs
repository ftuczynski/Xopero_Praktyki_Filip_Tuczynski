using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePage380 {
    class Program {
        static void Main(string[] args) {
            List<Duck> ducks = new List<Duck> {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 14 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 13 },
            };
            ///AddRange powinno przyjmować tylko IEnumerable ale działa z List (podręcznik str424)
            //IEnumerable<Bird> upcastDucks = ducks;
            List<Bird> birds = new List<Bird>();

            birds.Add(new Bird() { Name = "Feathers" });
            birds.AddRange(ducks);
            birds.Add(new Penguin() { Name = "George" });
            foreach(Bird bird in birds) {
                Console.WriteLine(bird);
            }

            Console.ReadKey();
        }
    }
}
