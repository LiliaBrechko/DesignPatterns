namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {

            DaysInMonthCollection collection = new DaysInMonthCollection(2025, 2025);

            foreach (MonthWithDays days in collection)
            {
                Console.WriteLine($"Days in {days.Date:yyyy-MM} - {days.Days}");
            }
        }
    }
}