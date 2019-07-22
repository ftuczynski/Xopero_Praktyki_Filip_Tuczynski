using System;

namespace ConsolePage629 {
    class Program {
        static void Main(string[] args) {
            //class
            Canine spot = new Canine("Spot", "pug");
            Canine bob = spot;
            bob.Name = "Spike";
            bob.Breed = "beagle";
            spot.Speak();
            //structure
            Dog jake = new Dog("Jake", "poodle");
            Dog betty = jake;
            betty.Name = "Betty";
            betty.Breed = "pit bull";
            jake.Speak();

            Console.ReadKey();
        }
    }
}
