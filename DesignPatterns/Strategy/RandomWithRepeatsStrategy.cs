namespace Strategy
{
    public class RandomWithRepeatsStrategy : IStrategy
    {

        private readonly List<Sector> Sectors;
        private readonly Random _random = new();
        private readonly List<Sector> PreviousSelections = new();

        public RandomWithRepeatsStrategy(List<Sector> sectors)
        {
            Sectors = sectors;
        }
        public void Spin()
        {
            if (Sectors.Count == PreviousSelections.Count)
            {
                Console.WriteLine("All sectors have been selected, resetting previous selections.");
                PreviousSelections.Clear();
            }

            Sector selected = Sectors.Except(PreviousSelections).ToList().OrderBy(x => _random.Next()).First();

            PreviousSelections.Add(selected);
            Console.WriteLine($"You price: {selected}");
        }
    }
}
