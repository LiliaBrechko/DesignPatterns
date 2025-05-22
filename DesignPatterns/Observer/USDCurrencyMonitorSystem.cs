namespace Observer
{
    public class USDCurrencyMonitorSystem
    {
        public event EventHandler<CurrencyChangedEventArgs> CurrencyChanged;
        public void UpdateRate(double rate)
        {
            Console.WriteLine($"USD rate updated to {rate}");

            if (CurrencyChanged == null)
            {
                Console.WriteLine("No subscribers");
                return;
            }
            foreach (Delegate subscriber in CurrencyChanged.GetInvocationList())
            {
                try
                {
                    subscriber.DynamicInvoke(this, new CurrencyChangedEventArgs(rate));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error notifying a bank: {ex.Message}");
                }
            }
        }
    }
}
