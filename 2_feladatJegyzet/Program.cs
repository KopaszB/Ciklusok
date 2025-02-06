using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_feladatJegyzet
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey key;
            
            do
            {
                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Művelet(/,*,-,+): ");
                string muvelet = Console.ReadLine();

                switch (muvelet)
                {
                    case "/":
                        if (b != 0)
                        {
                            Console.WriteLine($"{a} / {b} = {a / b}");
                        }
                        else
                        {
                            Console.WriteLine("Nullával nem osztunk!");
                        }
                        break;
                    case "*":
                        Console.WriteLine($"{a} * {b} = {a * b}");
                        break;
                    case "-":
                        Console.WriteLine($"{a} - {b} = {a - b}");
                        break;
                    case "+":
                        Console.WriteLine($"{a} + {b} = {a + b}");
                        break;

                    default:
                        Console.WriteLine("Nincs ilyen művelet!");
                        break;
                }
                Console.WriteLine("Újabb számítás (ENTER) | Kilépés (ESC)");
                key = Console.ReadKey(true).Key;
            } while (key!=ConsoleKey.Escape);
        }
    }
}
