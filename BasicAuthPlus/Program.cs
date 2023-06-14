namespace BasicAuthPlus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Toyoya.InitializeAdmin();

            Menus menu = new Menus();
            menu.MainMenus();


        }
    }
}