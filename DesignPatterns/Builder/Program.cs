namespace Builder
{
    class Program
    {
        public static void Main(string[] args)
        {
            UserBuilder userBuilder = new UserBuilder();
            UserDirector userDirector = new UserDirector(userBuilder);

            User Lilia = userBuilder.WithFirstName("Lilia").WithLastName("Brechko").WithEmail("lilia.brechko@gmail.com").WithAge(32).Build();

            User LiliaAdmin = userDirector.CreateAdmin(Lilia.FirstName, Lilia.LastName, Lilia.Age, Lilia.Email);

            Console.WriteLine(Lilia.ToString());
        }
    }
}
