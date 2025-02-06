using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_feladatJegyzet
{
    class Program
    {
        static void Main(string[] args)
        {
            int tippszam = 0;
            int count = 0;
            Random vszam = new Random();
            int gszam = vszam.Next(1,101);
            Console.WriteLine("Tippeld meg milyen számra gondoltam!" + gszam);

            while (tippszam!=gszam)
            {
                tippszam = int.Parse(Console.ReadLine());
                count++;
                if (tippszam<gszam)
                {
                    Console.WriteLine("A gondolt szám nagyobb!");
                }
                else if (tippszam>gszam)
                {
                    Console.WriteLine("A gondolt szam kisebb!");
                }
                else
                {
                    Console.WriteLine($"Eltaláltad {count} próbálkozásból!");
                }
            }
            Console.ReadKey();
        }
    }
}
