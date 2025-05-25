namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sector> sectors = new List<Sector> { Sector.Nothing, Sector.Car, Sector.Bike, Sector.Trip };

            FortuneWheel wheel = new FortuneWheel();

            wheel.SetStrategy(new RandomNoRepeatsStrategy(sectors));

            wheel.SpinWheel();

        }
    }
}

