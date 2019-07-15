using System;
using System.Collections.Generic;

enum Flapjack {
    Crispy,
    Soggy,
    Browned,
    Banana
}

namespace WindowsFormsPage405 {
    class Lumberjack {
        private string name;
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;

        public Lumberjack(string name) {
            this.name = name;
            meal = new Stack<Flapjack>();
        }

        public int FlapjackCount { get { return meal.Count; } }

        public void TakeFlapjacks(Flapjack food, int howMany) {
            for (int i = 0; i < howMany; i++)
                meal.Push(food);
        }

        public void EatFlapjacks() {
            Console.WriteLine(Name + "'s eating flapjacks");
            foreach(Flapjack flap in meal) {
                Console.WriteLine(Name + " ate a " + flap.ToString().ToLower() + " flapjack");
            }
        }
    }
}
