namespace BasicAuthPlus
{
    public class APerson
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }

        public APerson() { }

        public APerson(string firstname, string lastname, string username, string password, DateTime birthDate)
        {
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
            Password = password;
            BirthDate = birthDate;
        }
    }
}
