using System;

namespace ConsolePage638 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter birthday: ");
            string birthday = Console.ReadLine();
            Console.Write("Enter height in inches: ");
            string height = Console.ReadLine();
            RobustGuy guy = new RobustGuy(birthday, height);
            Console.WriteLine(guy.ToString());

            Console.ReadKey();
        }
    }
}
