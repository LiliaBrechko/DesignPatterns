namespace Command
{
    public class Bar : IRecieverOrder
    {
        public void Make(string itemName, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Bar: {itemName} served.");
            }
        }

        public void Cancel(string itemName, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Bar: {itemName} order canceled.");
            }
        }
    }
}
