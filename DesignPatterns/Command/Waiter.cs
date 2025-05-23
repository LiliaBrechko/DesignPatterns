namespace Command
{
    public class Waiter
    {
        private readonly List<IOrderCommand> _orders = new();
        private readonly Stack<IOrderCommand> _executedOrders = new();

        public void TakeOrder(IOrderCommand command)
        {
            _orders.Add(command);
            Console.WriteLine("Waiter: Order received.");
        }

        public void SendOrders()
        {
            Console.WriteLine("\n Sending orders...\n");

            foreach (IOrderCommand command in _orders)
            {
                command.Execute();
                _executedOrders.Push(command);
            }

            _orders.Clear();
        }

        public void UndoLastOrder()
        {
            if (_executedOrders.Count == 0)
            {
                Console.WriteLine("⚠️ Nothing to undo.");
                return;
            }

            IOrderCommand last = _executedOrders.Pop();
            last.Undo();
        }
    }
}
