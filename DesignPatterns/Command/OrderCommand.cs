namespace Command
{
    public class OrderCommand : IOrderCommand
    {

        private readonly IRecieverOrder _receiver;
        private readonly string _itemName;
        private readonly int _quantity;

        public OrderCommand(IRecieverOrder receiver, string itemName, int quantity)
        {
            _receiver = receiver;
            _itemName = itemName;
            _quantity = quantity;
        }

        public void Execute()
        {
            _receiver.Make(_itemName, _quantity);
        }

        public void Undo()
        {
            _receiver.Cancel(_itemName, _quantity);
        }
    }
}
