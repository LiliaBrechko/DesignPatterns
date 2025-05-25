namespace Strategy
{
    public class RandomNoRepeatsStrategy : IStrategy
    {
        public List<Sector> Sectors;
        private readonly Random _random = new();

        public RandomNoRepeatsStrategy(List<Sector> sectors)
        {
            Sectors = sectors;

        }

        public List<Sector> GetSectors()
        {
            return Sectors;
        }

        public void Spin()
        {
            int index = _random.Next(Sectors.Count);
            Console.WriteLine($"Your prise - {Sectors[index]}");
        }
    }

}
