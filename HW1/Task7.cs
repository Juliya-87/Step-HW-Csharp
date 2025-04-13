using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class Task7
    {
        public static void Execute()
        {
            Console.Write("Enter start range : ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter end range: ");
            int end = int.Parse(Console.ReadLine());

            if (start > end) 
            {
                int temp = start;
                start = end;
                end = temp;
            }

            Console.WriteLine("Numbers in range: ");
            for (int i = start; i < end; i++)
            {
                if (i % 2 == 0) 
                {
                    Console.Write(i + ", ");
                }
                
            }
        }
    }
}
