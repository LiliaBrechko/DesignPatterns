namespace Strategy
{
    public class FortuneWheel
    {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }
        public void SpinWheel()
        {
            _strategy.Spin();
        }
    }
}
