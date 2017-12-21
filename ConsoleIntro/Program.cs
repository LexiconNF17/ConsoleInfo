using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIntro
{
    class Program
    {
        static void Main()
        {
            int val1 = AskForInt("Ange värde 1");            
            int val2 = AskForInt("Ange värde 2");

            // Jämför
            var max = Util.Max(val1, val2);

            Console.WriteLine($"Du angav {val1} och {val2}");
            Console.WriteLine($"Det högsta värdet var {max}");
        }

        private static int AskForInt(string question)
        {
            int val;
            bool parsed;
            do
            {
                Console.WriteLine(question);
                var input = Console.ReadLine();
                parsed = int.TryParse(input, out val);
                if (!parsed)
                {
                    Console.WriteLine("Fel format");
                }
            } while (!parsed);
            return val;
        }
    }
}
