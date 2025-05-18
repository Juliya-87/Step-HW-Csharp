using System;

namespace HW2
{
    internal class Task1
    {
        public static void Execute()
        {

            var a = new double[5];

            Console.WriteLine("Please enter 5 double numbers: ");

            for (var i = 0; i < a.Length; i++)
            {
                Console.Write($"Element [{i}]: ");
                a[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("The array A: ");
            foreach (var t in a)
            {
                Console.Write(t + " ");
            }

            var b = new double[3, 4];

            var rnd = new Random();
            
            for (var row = 0; row < b.GetLength(0); row++)
            {
                for (var col = 0; col < b.GetLength(1); col++)
                {
                    b[row, col] = rnd.Next(10, 50) / 10.0;
                }
            }

            Console.WriteLine("\nThe array B with random double numbers: ");

            for (var row = 0; row < b.GetLength(0); row++)
            {
                for (var col = 0; col < b.GetLength(1); col++)
                {
                    Console.Write($"{b[row, col],8:F1} ");
                }
                Console.WriteLine();
            }

            var intersection = b.Cast<double>().Intersect(a).ToArray();
            if (intersection.Length == 0)
            {
                Console.WriteLine("The intersection was not found!");
            }
            else
            {
                var max = intersection.Max();
                Console.WriteLine($"The common max value of two arrays: {max}");
                var min = intersection.Min();
                Console.WriteLine($"The common min value of two arrays: {min}");
            }

            var commonArray = b.Cast<double>().Concat(a).ToArray();
            var sum = commonArray.Sum();
            Console.WriteLine($"The sum of all elements in the two arrays: {sum:F1}");

            var product = 1.0;

            foreach (var i in commonArray)
            {
                product *= i;
            }
            Console.WriteLine($"The product of all elements in both arrays: {product:F1}");

            var sumEvenElementsA = 0.0;

            foreach (var num in a)
            {
                var num1 = num / 2;
                var num2 = Math.Truncate(num1) * 2;

                if (num == num2)
                {
                    sumEvenElementsA += num;
                }
            }

            Console.WriteLine($"The sum of even elements of array A: {sumEvenElementsA:F1}");

            var sumOddColumnsB = 0.0;
            
            for (var row = 0; row < 3; row++)
            {
                for (var col = 0; col < 4; col++)
                {
                    if (col % 2 != 0)
                    {
                        sumOddColumnsB += b[row, col];
                    }
                }
            }

            Console.WriteLine($"The sum of odd elements of array B: {sumOddColumnsB:F1}");
        }
    }
}
