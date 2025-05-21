namespace Adapter
{
    public class AdapterInchesToMeters : IMetricConverter
    {
        private ImperialConverter _imperialConverter;
        public AdapterInchesToMeters(ImperialConverter imperialConverter)
        {
            _imperialConverter = imperialConverter;
        }
        public double GetMeters()
        {
            double inches = _imperialConverter.GetInches();
            double meters = inches * 0.0254;
            Console.WriteLine($"{inches} inches is {meters} meters");
            return meters;
        }
    }
}
