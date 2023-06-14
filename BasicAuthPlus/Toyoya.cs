namespace BasicAuthPlus
{
    public class Toyoya
    {
        public Dictionary<string, User> Users = new Dictionary<string, User>();
        public static Dictionary<string, Admin> Admins = new Dictionary<string, Admin>();
        public Helper helper = new Helper();

        public static void InitializeAdmin()
        {
            Admin admin = new Admin()
            {
                Nik = "AT/01",
                Firstname = "Andika",
                Lastname = "Daud",
                Username = "admin",
                Password = "admin",
                BirthDate = DateTime.Now,
            };

            Admins.Add(admin.Username, new Admin(admin.Nik, admin.Firstname, admin.Lastname, admin.Username, admin.Password, admin.BirthDate));
        }

        public void ProfileAdmin()
        {
            foreach (var adm in Admins.Values)
            {
                adm.PrintAdminInfo();
            }
        }

        public void CreateUsers()
        {
            string firstname, lastname, password, username;
            DateTime birthDate;
            int id = Users.Count + 1;
            Console.WriteLine("Fill The Form Below !!!");
            Console.WriteLine("Firstname: ");
            Console.Write("> ");
            firstname = helper.ValidasiString(1, 50);
            Console.WriteLine("Lastname: ");
            Console.Write("> ");
            lastname = helper.ValidasiString(1, 50);
            Console.WriteLine("Username: ");
            Console.Write("> ");
            username = helper.ValidasiString(1, 50);
            Console.WriteLine("Password: ");
            Console.Write("> ");
            password = helper.ValidasiString(1, 50);
            Console.WriteLine("Birthdate: ");
            Console.Write("> ");
            birthDate = helper.ValidasiDatetime();

            Users.Add(username, new User(id, firstname, lastname, username, password, birthDate));
            Console.WriteLine();
            Console.WriteLine("Berhasil Menambahkan Users");
            Console.WriteLine();
        }

        public void UpdateUsers()
        {
            if (Users.Count >= 1)
            {
                ShowUserByUsername();
                string firstname, lastname, password, username;
                Console.WriteLine("Input Usernane yang akan di Update");
                Console.Write("> ");
                string input = helper.ValidasiString(1, 50);
                if (Users.ContainsKey(input))
                {
                    Console.WriteLine("Masukan Data Users: ");
                    Console.WriteLine("Nama Depan: ");
                    Console.Write("> ");
                    firstname = helper.ValidasiString(1, 50);
                    Console.WriteLine("Nama Belakang: ");
                    Console.Write("> ");
                    lastname = helper.ValidasiString(1, 50);
                    Console.WriteLine("Password: ");
                    Console.Write("> ");
                    password = helper.ValidasiString(8, 50);
                    username = firstname.Substring(0, 2) + lastname.Substring(0, 2);

                    Users[input].Firstname = firstname;
                    Users[input].Lastname = lastname;
                    Users[input].Password = password;
                    Users[input].Username = username;
                    Console.WriteLine();
                    Console.WriteLine("User Berhasil diupdate");

                }
                else
                {
                    Console.WriteLine("User Not Found !");
                }

            }
            else
            {
                Console.WriteLine("User Not Found !!");
            }
        }
        public void DeleteUser()
        {
            if (Admins.Count >= 1)
            {
                ShowUserByUsername();
                Console.WriteLine("Input Username Yang ingin di delete");
                Console.Write("> ");
                string input = helper.ValidasiString(1, 50);
                if (Admins.ContainsKey(input))
                {
                    Admins.Remove(input);
                    Console.WriteLine();
                    Console.WriteLine("Akun Berhasil Di Hapus");
                }
                else
                {
                    Console.WriteLine("Username Salah!!");
                }
            }
            else
            {
                Console.WriteLine("Sorry Data Not Found !!");
            }
        }

        // print
        public void ShowUserByUsername()
        {
            string input;
            foreach (var i in Users.Values)
            {
                i.PrintUserInfo();
            }
        }

    }
}
