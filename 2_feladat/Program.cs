using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Első módszer
            for (int i = 5; i < 16; i++)
            {
                Console.WriteLine(i*2);
            }
            */
            /*
            //Második módszer
            for (int i = 10; i <= 30; i=i+1)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
            */
            //Harmadik módszer
            for (int i = 10; i < 31; i+=2)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
