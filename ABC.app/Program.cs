using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            int a = 5, b = 7;

            Console.WriteLine("ABC Console Demo");
            Console.WriteLine($"Add({a}, {b}) = {calc.Add(a, b)}");
            Console.WriteLine($"Sub({a}, {b}) = {calc.Sub(a, b)}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
