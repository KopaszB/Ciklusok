using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            for (int i = 0; i < szam; i++)
            {
                Console.WriteLine($"{i} | {szam-i-1}");
            }

            Console.ReadKey();
        }

    }
}
