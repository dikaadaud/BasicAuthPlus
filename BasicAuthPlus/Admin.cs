using System.Globalization;

namespace BasicAuthPlus
{
    public class Admin : APerson
    {
        public string Nik { get; set; }
        public Admin() { }

        public Admin(string nik, string firstname, string lastname, string username, string password, DateTime birthDate)
            : base(firstname, lastname, username, password, birthDate)
        {
            this.Nik = nik;
            base.BirthDate = birthDate;
            base.Firstname = firstname;
            base.Lastname = lastname;
            base.Username = username;
            base.Password = password;
        }

        private string GetFormattedIndonesianDate()
        {
            string input = BirthDate.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture("id-ID"));
            return input;
        }
        public void PrintAdminInfo()
        {
            Console.WriteLine($"Nik:  {Nik}");
            Console.WriteLine($"Firstname:  {Firstname}");
            Console.WriteLine($"Lastname: {Lastname}");
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Password: {Password}");
            Console.WriteLine("Birthdate: {0}", GetFormattedIndonesianDate());
        }
    }
}
