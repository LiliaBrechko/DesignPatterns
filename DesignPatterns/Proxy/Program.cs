namespace Proxy
{
    class Program
    {
        public static void Main(string[] args)
        {
            User Alice = new User("Alice", true);
            User Lilia = new User("Lili", false);

            ISubject secretDocument = new Proxy(Lilia, "Top Secret Document");
            secretDocument.Open();
        }
    }
}
