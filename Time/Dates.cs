namespace Practice1.Time
{
    public class Dates
    {
        public static void Start()
        {
            Console.WriteLine("\nReminder: All dates should be written in the 'mm/dd/yyyy' format.");
            Console.Write("\nPlease enter the first date: ");
            DateTime startDate = DateTime.Parse(Console.ReadLine() ?? string.Empty);

            Console.Write("Now enter the second date: ");
            DateTime endDate = DateTime.Parse(Console.ReadLine() ?? string.Empty);

            CalculateDifference(startDate, endDate);
        }

        private static void CalculateDifference(DateTime startDate, DateTime endDate)
        {
            TimeSpan difference = endDate - startDate;
            Console.WriteLine("\nThe difference between those dates is: {0} days\n", difference.Days);
        }
    }
}
