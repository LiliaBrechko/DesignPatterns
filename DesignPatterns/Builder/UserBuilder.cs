namespace Builder
{
    public class UserBuilder
    {
        private readonly User _user = new();

        public UserBuilder WithFirstName(string firstName)
        {
            _user.FirstName = firstName;
            return this;
        }
        public UserBuilder WithLastName(string lastName)
        {
            _user.LastName = lastName;
            return this;
        }
        public UserBuilder WithAge(int age)
        {
            _user.Age = age;
            return this;
        }
        public UserBuilder WithCountry(string country)
        {
            _user.Country = country;
            return this;
        }
        public UserBuilder WithEmail(string email)
        {
            _user.Email = email;
            return this;
        }
        public UserBuilder WithLanguage(string language)
        {
            _user.Language = language;
            return this;
        }
        public UserBuilder WithIsVerified(bool isVerified)
        {
            _user.IsVerified = isVerified;
            return this;
        }
        public UserBuilder WithIsAdmin(bool isAdmin)
        {
            _user.IsAdmin = isAdmin;
            return this;
        }
        public User Build()
        {
            if (string.IsNullOrWhiteSpace(_user.FirstName))
            {
                throw new InvalidOperationException("User must have a first name.");
            }
            if (string.IsNullOrWhiteSpace(_user.LastName))
            {
                throw new InvalidOperationException("User must have a last name.");
            }
            if (string.IsNullOrWhiteSpace(_user.Email))
            {
                throw new InvalidOperationException("User must have an email.");
            }
            if (_user.Age <= 0)
            {
                throw new InvalidOperationException("User must have a valid age.");
            }
            return _user;
        }
    }
}
