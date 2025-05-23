namespace Command
{
    public class Kitchen : IRecieverOrder
    {
        public void Make(string itemName, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Kitchen: {itemName} prepared.");
            }
        }

        public void Cancel(string itemName, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Kitchen: {itemName} order canceled.");
            }
        }
    }
}
