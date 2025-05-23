namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            USDCurrencyMonitorSystem monitorUSD = new USDCurrencyMonitorSystem();
            CurrencyObserver bank1 = new CurrencyObserver("Bank1");

            monitorUSD.CurrencyChanged += bank1.OnCurrencyChanged;
            monitorUSD.UpdateRate(41.2);


        }
    }
}