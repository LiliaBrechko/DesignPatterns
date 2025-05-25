namespace ChainOfResponsibility
{
    public class OperatorHandler : SupportHandler
    {
        public override void Handle(SupportRequest request)
        {
            if (request.TypeOfRequest == TypeOfRequest.TechnicalSupport)
            {
                Console.WriteLine($"Operator handled");
            }
            else
            {
                _next?.Handle(request);
            }
        }
    }
}
