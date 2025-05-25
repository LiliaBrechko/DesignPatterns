namespace ChainOfResponsibility
{
    public class ManagerHandler : SupportHandler
    {
        public override void Handle(SupportRequest request)
        {
            if (request.TypeOfRequest == TypeOfRequest.GeneralInquiry)
            {
                Console.WriteLine($"Manager handled");
            }
            else
            {
                _next?.Handle(request);
            }
        }
    }
}
