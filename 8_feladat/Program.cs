using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            double osszeg = 0;
            double atlag;
            Console.WriteLine("Add meg a hónapok közép-hőmérsékletét!");
            /*
            for (int i = 1; i <= 12; i++)
            {
                Console.Write($"{i}. hónap: ");
                double h = double.Parse(Console.ReadLine());
                osszeg = osszeg + h;
            }
            atlag = osszeg / 12;
            Console.WriteLine($"Az éves közép-hőmérséklet: {Math.Round(atlag,2)}");
            */
            int i = 1;
            do
            {
                Console.Write($"{i}. hónap: ");
                double h = double.Parse(Console.ReadLine());
                osszeg = osszeg + h;
                i++;
            } while (i<13);
            atlag = osszeg / 12;
            Console.WriteLine($"Az éves közép-hőmérséklet: {Math.Round(atlag, 2)}");

            Console.ReadKey();
        }
    }
}
