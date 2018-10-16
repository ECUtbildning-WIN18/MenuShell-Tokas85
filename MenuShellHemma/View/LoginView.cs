using System;
using System.Threading;
using MenuShellHemma.Domain;

namespace MenuShellHemma.View
{
    class LoginView
    {
        public virtual void Display()
        {
            var adminMainView = new AdminMainView();
            var receptionistMainView = new ReceptionistMainView();
            var veterinaryMainView = new VeterinaryMainView();

            var menuInput = true;
            while (menuInput)
            {
                Console.WriteLine("Please log in\n");

                Console.Write("Username: ");
                var username = Console.ReadLine();

                Console.Write("Password: ");
                var password = Console.ReadLine();

                var yesOrNo = true;
                while (yesOrNo)
                {
                    Console.WriteLine("\nIs this correct? (Y)es (N)o");
                    var keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.Y)
                    {
                        var authenticationService = new AuthenticationService();

                        var user = authenticationService.Authenticate(username, password);

                        if (user != null)
                        {
                            Console.WriteLine("\nSuccessfully logged in!");
                            Console.WriteLine($"Role {user.Role}");
                            menuInput = false;
                            yesOrNo = false;

                            switch (user.Role)
                            {
                                case "receptionist":
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    receptionistMainView.Display();
                                    break;
                                case "veterinary":
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    veterinaryMainView.Display();
                                    break;
                                case "sysadmin":
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    adminMainView.Display();
                                    break;

                            }

                        }
                        else
                        {
                            Console.WriteLine("\nLogin failed. Please try again.");
                            Thread.Sleep(2000);
                            Console.Clear();
                            yesOrNo = false;
                        }
                    }
                    else if (keyInfo.Key == ConsoleKey.N)
                    {
                        Console.Clear();
                        yesOrNo = false;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid selection!");
                        Thread.Sleep(1000);
                    }
                }
                
            }

                

        }
    }
}
