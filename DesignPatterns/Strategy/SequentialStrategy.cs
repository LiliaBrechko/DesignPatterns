namespace Strategy
{
    public class SequentialStrategy : IStrategy
    {
        private readonly Queue<Sector> _queue;

        public SequentialStrategy(List<Sector> sectors)
        {
            _queue = new Queue<Sector>(sectors);
        }

        public void Spin()
        {
            Sector current = _queue.Dequeue();
            Console.WriteLine($"You won: {current}");
            _queue.Enqueue(current);
        }
    }

}
