namespace HW1
{
    internal class Task8
    {
        public static void Execute()
        {
            Console.Write("Enter a number: ");
            var userNum = Console.ReadLine();
            var digits = userNum.Select(char.GetNumericValue).ToArray();

            double result = 0;
            for ( int i = 0; i < digits.Length; i++ )
            {
                double digitsPow = Math.Pow(digits[i], digits.Length);
                result += digitsPow;
            }
            
            string resultStr = result.ToString();
            if (resultStr.Equals(userNum))
            {
                Console.WriteLine("The number is Armstrong number.");
            }
            else 
            { 
                Console.WriteLine("The number is not Armstrong number.");
            }
        }
    }
}
