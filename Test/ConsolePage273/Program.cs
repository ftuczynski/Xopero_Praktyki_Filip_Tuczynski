using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePage273
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBaseClass myBaseClass = new MyBaseClass("This is constructor for MyBaseClass");
            MySubclass mySubclass = new MySubclass("This is constructor fo r mySybclass",13);

            Console.ReadKey();
        }
    }
}
