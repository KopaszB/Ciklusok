using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int ertek = 1;
            Console.Write("Add meg a számot: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Add meg a hatványát: ");
            int h = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= Math.Abs(h); i++)
            {
                ertek = ertek * a;
            }

            if (h>0)
            {
                Console.WriteLine($"{a}^{h} = {ertek}");
            }
            else if (h<0 && a!=0)
            {
                Console.WriteLine($"{a}^{h} = {(double)1/ertek}");
            }
            else if (h == 0 && a!=0)
            {
                Console.WriteLine($"{a}^{h} = {1}");
            }
            else
            {
                Console.WriteLine($"{a}^{h} = {0}");
            }
            

            Console.ReadKey();
        }
    }
}
