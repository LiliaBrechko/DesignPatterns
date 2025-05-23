namespace Builder
{
    public class UserDirector
    {
        private readonly UserBuilder _builder;

        public UserDirector(UserBuilder builder)
        {
            _builder = builder;
        }

        public User CreateAdmin(string firstName, string lastName, int age, string email)
        {
            return _builder
                .WithFirstName(firstName)
                .WithLastName(lastName)
                .WithAge(age)
                .WithEmail(email)
                .WithIsAdmin(true)
                .WithIsVerified(true)
                .Build();
        }

        public User CreateGuest()
        {
            return _builder
                .WithFirstName("Guest")
                .WithIsVerified(false)
                .Build();
        }
    }
}
