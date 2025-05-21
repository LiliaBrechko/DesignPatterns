namespace Adapter
{
    public class ImperialConverter
    {
        private double _lengthInInches;

        public ImperialConverter(double lengthInInches)
        {
            _lengthInInches = lengthInInches;
        }
        public double GetInches()
        {
            return _lengthInInches;
        }
    }
}
