using System.Globalization;

namespace BasicAuthPlus
{
    public class User : APerson
    {
        public int Id { get; set; }

        public User() { }

        public User(int id, string firstname, string lastname, string username, string password, DateTime birthDate)
            : base(firstname, lastname, username, password, birthDate)
        {
            base.BirthDate = birthDate;
            base.Firstname = firstname;
            base.Lastname = lastname;
            base.Username = username;
            base.Password = password;
            Id = id;
        }

        private string GetIndonesianDate()
        {
            return base.BirthDate.ToString("dd MMMM yyyy", CultureInfo.GetCultureInfo("id-ID"));
        }

        public void PrintUserInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Firstname:  {Firstname}");
            Console.WriteLine($"Lastname: {Lastname}");
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Password: {Password}");
            Console.WriteLine("Birthdate: {0}", GetIndonesianDate());
        }
    }
}
