namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            USDCurrencyMonitorSystem monitorUSD = new USDCurrencyMonitorSystem();
            CurrencyObserver bank1 = new CurrencyObserver("Bank 1");
            CurrencyObserver bank2 = new CurrencyObserver("Bank 2");

            monitorUSD.CurrencyChanged += bank1.NotifyOnCurrencyChanged;

            monitorUSD.UpdateRate(41.20);

        }
    }
}
