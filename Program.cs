using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_15_assign_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone("Iphone 14");
            smartphone.Connect();
            smartphone.Charge(120);
            Console.WriteLine(smartphone.Display());

            Console.WriteLine();

            Laptop laptop = new Laptop("MacBook Pro");
            laptop.Connect();
            laptop.Charge(90);
            Console.WriteLine(laptop.Display());
            Console.ReadKey();
        }
    }
}
