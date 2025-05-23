namespace Command
{
    public interface IRecieverOrder
    {
        void Make(string itemName, int quantity);
        void Cancel(string itemName, int quantity);
    }
}
