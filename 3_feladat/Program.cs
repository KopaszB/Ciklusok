using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg az első számot: ");
            int also = int.Parse(Console.ReadLine());
            Console.Write("Add meg a második számot: ");
            int felso = int.Parse(Console.ReadLine());

            if (also<felso)
            {
                for (int i = also; i < felso + 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else if (felso<also)
            {
                for (int i = felso; i < also + 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("A megadott határértékek között nincs szám!");
            }

            

            Console.ReadKey();
        }
    }
}
