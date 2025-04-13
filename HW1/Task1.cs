namespace HW1
{
    internal class Task1
    {
        public static void Execute()
        {
            Console.Write("Enter number from 1 to 100: ");
            int num = int.Parse(Console.ReadLine());
            if (num < 1 || num > 100)
            {
                Console.WriteLine("The number isn't in range from 1 to 100");
                return; 
            }

            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.Write("Fizz Buzz");
            }
            else if (num % 3 == 0)
            {
                Console.Write("Fizz");
            }
            else if (num % 5 == 0)
            {
                Console.Write("Buzz");
            }
            else
            {
                Console.WriteLine(num);
            }
        }
    }
}
