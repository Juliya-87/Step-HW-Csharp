namespace HW1
{
    internal class Task6
    {
        public static void Execute()
        {
            const double fahrenheitOffset = 32;
            const double celsiusMultiplier = 5;
            const double fahrenheitMultiplier = 9;

            Console.Write("Enter temperature: ");
            double initTempr = double.Parse(Console.ReadLine());

            Console.WriteLine("Select option: f - show in Fahrenheit, c - show in Celsius");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "f":
                    double temprFahrenheit = (initTempr * fahrenheitMultiplier / celsiusMultiplier) + fahrenheitOffset;
                    Console.Write($"Temperature in Fahrenheit: {temprFahrenheit:F2}");
                    break;
                case "c":
                    double temprCelsius = (initTempr - fahrenheitOffset) * celsiusMultiplier / fahrenheitMultiplier; ;
                    Console.Write($"Temperature in Celsius: {temprCelsius:F2}");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
