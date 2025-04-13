using System.Globalization;

namespace HW1
{
    internal class Task5
    {
        public static void Execute()
        {
            Console.Write("Enter date in format dd.mm.yyyy: ");
            var dateString = Console.ReadLine();
            var format = "dd.MM.yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;

            var result = DateTime.ParseExact(dateString, format, provider);
            var month = result.Month;

            if (month >= 3 && month <= 5)
            {
                Console.Write("Spring");
            }
            else if (month >= 6 && month <= 8)
            {
                Console.Write("Summer");
            }
            else if (month >= 9 && month <= 11)
            {
                Console.Write("Autumn");
            }
            else 
            { 
                Console.Write("Winter"); 
            }

            var dayOfWeek = result.DayOfWeek;
            Console.Write($" {dayOfWeek}");
        }
    }
}
