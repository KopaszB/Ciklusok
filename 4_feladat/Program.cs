using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam;
            int db = 0;
            Console.Write("Adj meg egy számot:");
            szam = int.Parse(Console.ReadLine());
            szam = Math.Abs(szam);
            do
            {
                szam = szam / 10;
                db++;
                
            } while (szam>=1);
            Console.WriteLine($"A szám {db} számjegyből áll.");

            Console.ReadKey();
        }
    }
}
