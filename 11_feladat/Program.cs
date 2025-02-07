using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int vszam;
            int szamlalo = 0;
            for (int i = 1; i <= 40; i++)
            {
                vszam = rnd.Next(-100, 100);
                Console.Write($"{vszam,6}");
                if (vszam<0)
                {
                    szamlalo++;
                }
                if (i%8==0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"{szamlalo} db pozitív szám van.");
            Console.ReadKey();
        }
    }
}
