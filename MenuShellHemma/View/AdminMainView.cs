using System;
using System.Threading;

namespace MenuShellHemma.View
{
    class AdminMainView
    {
        public void Display()
        {
            var loginView = new LoginView();
            var adminAddUserViewDB = new AdminAddUserViewDB();
            var adminDeleteUserViewDB = new AdminDeleteUserViewDB();
            var userSearchViewDB = new UserSearchViewDB();
            var userSearchView = new UserSearchView();
            var adminAddUserView = new AdminAddUserView();
            var adminDeleteUserView = new AdminDeleteUserView();

            Console.WriteLine("Welcome Admin!");
            Console.WriteLine();
            Console.WriteLine("(1) Search user");
            Console.WriteLine("(2) Add user");
            Console.WriteLine("(3) Delete user");
            Console.WriteLine("(4) Logout");
            Console.WriteLine("(5) Exit");

            var menuInputLoop = true;
            while (menuInputLoop)
            {
                var menuInputKey = Console.ReadKey();
                Console.WriteLine();
                switch (menuInputKey.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        userSearchView.Display();
                        menuInputLoop = false;
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        adminAddUserView.Display();
                        menuInputLoop = false;
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        adminDeleteUserView.Display();
                        menuInputLoop = false;
                        break;

                    case ConsoleKey.D4:
                        Console.WriteLine();
                        Console.WriteLine("Logging out...");
                        Thread.Sleep(1000);
                        Console.WriteLine("Good bye!");
                        Thread.Sleep(2000);
                        Console.Clear();
                        loginView.Display();

                        break;

                    case ConsoleKey.D5:
                        Console.WriteLine();
                        Console.WriteLine("Closing the application...");
                        Thread.Sleep(1000);
                        Console.WriteLine("Good bye!");
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Wrong input!");
                        Console.Write("Try again: ");
                        break;
                }
            }
        }
    }
}
