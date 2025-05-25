namespace Proxy
{
    public class User
    {
        public string Name { get; }
        public bool isAdmin { get; }

        public User(string name, bool role)
        {
            Name = name;
            isAdmin = role;
        }

    }
}
