using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class Task3
    {
        public static void Execute()
        {
            Console.Write("Enter digit 1: ");
            string dig1 = Console.ReadLine();

            Console.Write("Enter digit 2: ");
            string dig2 = Console.ReadLine();

            Console.Write("Enter digit 3: ");
            string dig3 = Console.ReadLine();

            Console.Write("Enter digit 4: ");
            string dig4 = Console.ReadLine();

            string num = dig1 + dig2 + dig3 + dig4;
            int result = int.Parse(num);

            Console.Write($"Result: {result}");

        }
    }
}
