namespace Observer
{
    public class CurrencyObserver
    {
        public string Name { get; }

        public CurrencyObserver(string name)
        {
            Name = name;
        }

        public void OnCurrencyChanged(object sender, CurrencyChangedEventArgs e)
        {
            Console.WriteLine($"{Name} received update: {e.NewRate}");

            if (Name == "ProblemBank")
            {
                throw new Exception("Service temporarily unavailable");
            }
        }
    }
}
