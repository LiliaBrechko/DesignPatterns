namespace Proxy
{
    public class SecretDocument : ISubject
    {
        private readonly string _secret;
        public SecretDocument(string secret)
        {
            _secret = secret;
        }
        public void Open()
        {
            Console.WriteLine($"Secret document {_secret}");
        }
    }
}
