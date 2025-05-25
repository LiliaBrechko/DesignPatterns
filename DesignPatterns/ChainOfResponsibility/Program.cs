namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            OperatorHandler operatorHandler = new OperatorHandler();
            ManagerHandler managerHandler = new ManagerHandler();
            DirectorHandler directorHandler = new DirectorHandler();

            // Set up the chain of responsibility

            operatorHandler.SetNext(managerHandler);
            managerHandler.SetNext(directorHandler);

            SupportRequest request1 = new SupportRequest(TypeOfRequest.TechnicalSupport);
            SupportRequest request2 = new SupportRequest(TypeOfRequest.GeneralInquiry);
            SupportRequest request3 = new SupportRequest(TypeOfRequest.AccountManagement);
            SupportRequest request4 = new SupportRequest(TypeOfRequest.Feedback);

            List<SupportRequest> requests = new List<SupportRequest> { request1, request2, request3, request4 };

            foreach (SupportRequest request in requests)
            {
                Console.WriteLine($"Handling request of type: {request.TypeOfRequest}");
                operatorHandler.Handle(request);
                Console.WriteLine();
            }
        }

    }
}