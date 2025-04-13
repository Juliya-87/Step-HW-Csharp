using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class Task2
    {
        public static void Execute()
        {
            const int PERCENT_DIVISOR = 100;

            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter percent: ");
            int percent = int.Parse(Console.ReadLine());

            int result = number * percent / PERCENT_DIVISOR;

            Console.Write("Result = " + result);
        }
    }
}
