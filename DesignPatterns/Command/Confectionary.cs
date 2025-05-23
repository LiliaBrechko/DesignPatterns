namespace Command
{
    public class Confectionary : IRecieverOrder
    {
        public void Make(string itemName, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Confectionary: {itemName} ready.");
            }
        }

        public void Cancel(string itemName, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Confectionary: {itemName} order canceled.");
            }
        }
    }
}
