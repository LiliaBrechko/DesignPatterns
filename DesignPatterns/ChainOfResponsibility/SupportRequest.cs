namespace ChainOfResponsibility
{
    public class SupportRequest
    {

        public TypeOfRequest TypeOfRequest { get; }

        public SupportRequest(TypeOfRequest typeOfRequest)
        {
            TypeOfRequest = typeOfRequest;
        }
    }
}
