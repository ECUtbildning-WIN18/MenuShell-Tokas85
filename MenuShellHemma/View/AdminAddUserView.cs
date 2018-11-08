using System;
using System.Threading;
using System.Xml.Linq;

namespace MenuShellHemma.View
{
    class AdminAddUserView
    {
        public void Display()
        {
            var adminMainView = new AdminMainView();
            var doc = XDocument.Load("Users.xml");
            var root = doc.Root;


            Console.WriteLine("# Add user");
            Console.WriteLine();
            Console.Write("Username: ");
            var username = Console.ReadLine();
            Console.Write("Password: ");
            var password = Console.ReadLine();
            Console.Write("Role: ");
            var role = Console.ReadLine();
            Console.WriteLine();

            var yesOrNo = true;
            while (yesOrNo)
            {
                Console.WriteLine("Is this correct? (Y)es (N)o ");
                var keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Y)
                {
                    root.Add(new XElement("User",
                        new XAttribute("username", username),
                        new XAttribute("password", password),
                        new XAttribute("role", role)));
                    doc.Save("Users.xml");
                    Console.WriteLine("\nNew user added!");
                    Thread.Sleep(1000);
                    Console.WriteLine("Returning to menu..");
                    Thread.Sleep(1000);
                    Console.Clear();
                    adminMainView.Display();
                }
                else if (keyInfo.Key == ConsoleKey.N)
                {
                    Console.WriteLine("\nCancel..");
                    Thread.Sleep(1000);
                    Console.WriteLine("Returning to menu..");
                    Thread.Sleep(1000);
                    Console.Clear();
                    adminMainView.Display();
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
