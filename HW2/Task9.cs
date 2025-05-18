namespace HW2

{
    internal class Task9
    {
        public static void Execute()
        {
            Console.Write("Please enter number of rows, columns, and multiplier (separated by space): ");
            var userPrompt = Console.ReadLine();
            var splitedUserPrompt = userPrompt.Split(' ');

            if (splitedUserPrompt.Length != 3)
            {
                Console.WriteLine("Please enter exactly three numbers separated by spaces.");
                return;
            }

            var row = int.Parse(splitedUserPrompt[0]);
            var col = int.Parse(splitedUserPrompt[0]);
            var multiplier = int.Parse(splitedUserPrompt[2]);

            var array = new int[row, col];
            var randomArray = new Random();

            Console.WriteLine("The random array:");

            for (var i = 0; i < row; i++)
            {
                for (var j = 0; j < col; j++)
                {
                    array[i, j] = randomArray.Next(1, 10);
                    Console.Write($"{array[i, j],4}");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nThe array after multiplication by {multiplier}:");

            for (var i = 0; i < row; i++)
            {
                for (var j = 0; j < col; j++)
                {
                    array[i, j] *= multiplier;
                    Console.Write($"{array[i, j],4}");
                }
                Console.WriteLine();
            }
        }
    }
}