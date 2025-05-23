namespace Builder
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Language { get; set; }
        public bool IsVerified { get; set; }
        public bool IsAdmin { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Age}) -  [{Email}]";
        }
    }

}
