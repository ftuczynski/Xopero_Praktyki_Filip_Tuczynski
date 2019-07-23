using System;
using MyExtensions;

namespace ConsolePage644 {
    class Program {
        static void Main(string[] args) {
            string message = "Clones are wreaking havoc at the factory. Help!";
            if (message.IsDistressCall())
                Console.WriteLine("I'm doing something!");

            Console.ReadKey();
        }
    }
}
