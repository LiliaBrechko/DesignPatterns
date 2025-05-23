namespace Observer
{
    public class CurrencyChangedEventArgs : EventArgs
    {

        public double NewRate { get; }

        public CurrencyChangedEventArgs(double newRate)
        {

            NewRate = newRate;
        }
    }
}
