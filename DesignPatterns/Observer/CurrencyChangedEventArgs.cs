namespace Observer
{
    public class CurrencyChangedEventArgs : EventArgs
    {

        public double NewRate { get; set; }

        public CurrencyChangedEventArgs(double newRate)
        {

            NewRate = newRate;
        }
    }
}
