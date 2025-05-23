namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitchen kitchen = new Kitchen();
            Bar bar = new Bar();
            Confectionary confectionary = new Confectionary();

            Waiter waiter = new Waiter();

            OrderCommand order1 = new OrderCommand(kitchen, "Pizza", 2);
            OrderCommand order2 = new OrderCommand(bar, "Cocktail", 3);
            OrderCommand order3 = new OrderCommand(confectionary, "Cake", 1);

            waiter.TakeOrder(order1);
            waiter.TakeOrder(order2);
            waiter.TakeOrder(order3);

            waiter.SendOrders();

            waiter.UndoLastOrder();


        }
    }


}