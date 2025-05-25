namespace ChainOfResponsibility
{
    public abstract class SupportHandler
    {
        protected SupportHandler _next;

        public void SetNext(SupportHandler next)
        {
            _next = next;
        }

        public abstract void Handle(SupportRequest request);
    }
}
