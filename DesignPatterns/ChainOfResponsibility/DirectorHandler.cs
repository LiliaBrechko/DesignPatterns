namespace ChainOfResponsibility
{
    public class DirectorHandler : SupportHandler
    {
        public override void Handle(SupportRequest request)
        {
            if (request.TypeOfRequest == TypeOfRequest.AccountManagement)
            {
                Console.WriteLine($"Director handled");
            }
            else
            {
                Console.WriteLine($"No handler for level");
            }
        }
    }
}
