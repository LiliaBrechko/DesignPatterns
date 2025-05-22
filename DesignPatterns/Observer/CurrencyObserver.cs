namespace Observer
{
    class CurrencyObserver
    {
        public string Name { get; set; }
        public CurrencyObserver(string name)
        {
            Name = name;
        }

        public void NotifyOnCurrencyChanged(object sender, CurrencyChangedEventArgs change)
        {
            Console.WriteLine($"Notifying {Name} about currency change. New rate: {change.NewRate}");
        }
    }
}
