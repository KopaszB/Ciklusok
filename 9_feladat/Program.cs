using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérek egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine($"{szam} osztói: ");
            for (int i = 1; i <= szam/2; i++)
            {
                if (szam%i==0)
                {
                    Console.WriteLine(szam/i);
                }
            }
            Console.WriteLine(1);
            Console.ReadKey();
        }
    }
}
