namespace BasicAuthPlus
{
    public class Menus
    {
        public Helper Helper { get; set; } = new Helper();
        public Toyoya Toyoya { get; set; } = new Toyoya();

        public void MainMenus()
        {
            Console.WriteLine("Welcome To Sahara");
            Console.WriteLine("1. Log in\n2. Exit");
            Console.Write("> ");
            int input = Helper.ValidasiINT(1, 2);
            switch (input)
            {
                case 1:
                    Login();
                    break;
                default:
                    Console.WriteLine("Terimakasih Sudah Menggunakan Aplikasi Ini");
                    Environment.Exit(0);
                    break;
            }
        }

        public void Login()
        {
            string username, password;
            Console.WriteLine("======= Sahara =======");
            Console.WriteLine("Username: ");
            Console.Write("> ");
            username = Helper.ValidasiString(1, 50);
            Console.WriteLine("Password: ");
            Console.Write("> ");
            password = Helper.ValidasiString(1, 50);
            if (Toyoya.Admins.ContainsKey(username) && Toyoya.Admins[username].Password == password)
            {
                MenuAdmin();
            }
            else if (Toyoya.Users.ContainsKey(username) && Toyoya.Users[username].Password == password)
            {
                MenuUser();
            }
            else
            {
                Console.WriteLine("Username / Password Salah !! Coba lagi");
                Login();
            }
        }

        public void MenuAdmin()
        {
            Console.WriteLine("===== Menu Admin =====");
            Console.WriteLine("1. Profile Admin\n2. Create User\n3. Update User\n4. Delete User\n5. Logout");
            Console.Write("> ");
            int input = Helper.ValidasiINT(1, 5);
            switch (input)
            {
                case 1:
                    Console.Clear();
                    Toyoya.ProfileAdmin();
                    MenuAdmin();
                    break;
                case 2:
                    Console.Clear();
                    Toyoya.CreateUsers();
                    MenuAdmin();
                    break;
                case 3:
                    Console.Clear();
                    Toyoya.UpdateUsers();
                    MenuAdmin();
                    break;
                case 4:
                    Console.Clear();
                    Toyoya.DeleteUser();
                    MenuAdmin();
                    break;
                default:
                    MainMenus();
                    break;
            }

        }
        public void MenuUser()
        {
            Console.WriteLine("========== Menu User ==========");

            Console.WriteLine("1. Cek ganjil / genap\n2. Print Ganjil/Genap (Dengan Limit)\n3. Logout");
            Console.Write("> ");
            int input = Helper.ValidasiINT(1, 4);
            switch (input)
            {
                case 1:
                    Console.Clear();
                    MenuUser1();
                    Console.WriteLine();
                    MenuUser();
                    break;
                case 2:
                    Console.Clear();
                    MenuUser2();
                    Console.WriteLine();
                    Console.WriteLine();
                    MenuUser();
                    break;
                default:
                    MainMenus();
                    break;
            }
        }
        public static void MenuUser1()
        {
            Console.Write("Masukan Bilangan Yang Ingin di cek: ");
            PrintEvenOdd();
        }
        public static int PrintEvenOdd()
        {
            int input;
            bool isValid = int.TryParse(Console.ReadLine(), out input);
            if (!isValid || input >= 1)
            {

                if (input % 2 == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("> Genap");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("> Ganjil");
                }

            }
            else
            {
                Console.WriteLine("Invalid Input");
                Console.Write("> ");
                PrintEvenOdd();
            }
            return input;
        }
        public static void MenuUser2()
        {

            Console.WriteLine("Pilih Ganjil/Genap: ");
            Console.Write("> ");
            EvenOddValidation();
        }
        public static void EvenOddValidation()
        {
            string input = Console.ReadLine().ToLower();
            bool isEven = false;
            while (!isEven)
            {
                if (input == "ganjil")
                {
                    Ganjil();
                    isEven = true;
                }
                else if (input == "genap")
                {
                    Genap();
                    isEven = true;
                }
                else
                {
                    Console.WriteLine("Input pilihan tidak valid");
                    Console.Write("> ");
                    input = Console.ReadLine().ToLower();
                }
            }
        }
        public static void Ganjil()
        {
            Console.WriteLine("Masukan limit: ");
            Console.Write("> ");
            int ganjil = int.Parse(Console.ReadLine().ToLower());
            bool isEven = false;
            while (!isEven)
            {
                if (ganjil % 2 != 0 && ganjil > 0)
                {
                    Console.WriteLine();
                    for (int i = 1; i < ganjil; i += 2)
                    {
                        Console.WriteLine($"{i},");
                    }
                    isEven = true;
                }
                else
                {
                    Console.WriteLine("Input pilihan tidak valid");
                    Console.Write("Masukan limit: ");
                    ganjil = int.Parse(Console.ReadLine());
                }
            }

        }
        public static void Genap()
        {
            Console.WriteLine("Masukan limit: ");
            Console.Write("> ");
            int genap = int.Parse(Console.ReadLine().ToLower());
            bool isOdd = false;
            while (!isOdd)
            {
                Console.WriteLine();
                if (genap % 2 == 0 && genap > 0)
                {
                    for (int i = 2; i < genap; i += 2)
                    {
                        Console.WriteLine($"{i},");
                    }
                    isOdd = true;
                }
                else
                {
                    Console.WriteLine("Input pilihan tidak valid");
                    Console.Write("Masukan limit: ");
                    genap = int.Parse(Console.ReadLine());
                }
            }
        }

    }
}
