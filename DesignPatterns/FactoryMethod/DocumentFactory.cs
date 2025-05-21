namespace FactoryMethod
{
    public static class DocumentFactory
    {
        public static IDocument CreateDocument()
        {
            Console.WriteLine("Creating document.");
            Console.WriteLine("Select document type: 1. PDF 2. Excel 3. Word");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Creating Pdf document.");
                    return new PdfDocument();
                case "2":
                    Console.WriteLine("Creating Excel document.");
                    return new ExcelDocument();
                case "3":
                    Console.WriteLine("Creating Word document.");
                    return new WordDocument();
                default:
                    throw new ArgumentException("Invalid document type.");
            }
        }
    }
}
