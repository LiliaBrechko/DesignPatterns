namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            AdapterInchesToMeters adapter = new AdapterInchesToMeters(new ImperialConverter(5));
            adapter.GetMeters();


        }
    }
}
