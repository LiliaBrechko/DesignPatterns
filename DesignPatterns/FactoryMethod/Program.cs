namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IDocument document = DocumentFactory.CreateDocument();
            document.Open();
            document.Save();


        }
    }
}
