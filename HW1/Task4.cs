namespace HW1
{
    internal class Task4
    {
        const int rangeStart = 1;
        const int rangeEnd = 6;
        public static void Execute() 
        {
            Console.Write($"Enter a {rangeEnd}-digit number: ");
            string userInput = Console.ReadLine();

            int length = userInput.Length;
            if (length != rangeEnd)
            {
                Console.WriteLine($"The number isn't a {rangeEnd}-digit number");
                return;
            }

            var digitPosition1 = GetDigitPosition("Enter first digit number: ");
            var digitPosition2 = GetDigitPosition("Enter second digit number: ");

            if (!digitPosition1.HasValue || !digitPosition2.HasValue)
            {
                return;
            }

            var digArr = userInput.ToCharArray();

            char temp = digArr[digitPosition1.Value];
            digArr[digitPosition1.Value] = digArr[digitPosition2.Value];
            digArr[digitPosition2.Value] = temp;

            var result = new string(digArr);

            Console.WriteLine($"Result: { result}");
        }

        public static int? GetDigitPosition(string prompt)
        {
            Console.Write(prompt);
            int digit = int.Parse(Console.ReadLine());

            if (digit < rangeStart || digit > rangeEnd)
            {
                Console.WriteLine($"Invalid number. The number should be in the range from {rangeStart} to {rangeEnd}.");
                return null;
            }

            return rangeEnd - digit;
        }
    }
}
