namespace Proxy
{
    public class Proxy : ISubject
    {
        private readonly SecretDocument _secretDocument;
        private readonly User _user;

        public Proxy(User user, string secret)
        {
            _user = user;
            _secretDocument = new SecretDocument(secret);
        }
        public void Open()
        {
            Console.WriteLine($"User {_user.Name} is trying to access the secret document.");

            if (_user.isAdmin)
            {
                Console.WriteLine($"User {_user.Name} is an admin. Access granted.");
                _secretDocument.Open();
            }
            else
            {
                Console.WriteLine("Access denied. You are not an admin.");
            }
        }
    }
}
