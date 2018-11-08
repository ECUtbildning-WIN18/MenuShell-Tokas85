using System;
using System.Linq;
using System.Threading;
using System.Xml.Linq;

namespace MenuShellHemma.View
{
    class AdminDeleteUserView
    {
        public void Display()
        {
            var adminMainView = new AdminMainView();

            Console.WriteLine("# Delete user");
            Console.WriteLine();

            var doc = XDocument.Load("Users.xml");
            var root = doc.Root;
            foreach (var element in root.Elements())
            {
                Console.WriteLine(element.Attribute("username").Value);
                Console.WriteLine(element.Attribute("role").Value);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Remove username: ");
            var username = Console.ReadLine();
            Console.WriteLine();

            var yesOrNo = true;
            while (yesOrNo)
            {
                Console.WriteLine("Are you sure? (Y)es (N)o");
                var keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Y)
                {
                    doc.Descendants("User").Where(p => p.Attribute("username").Value == username).FirstOrDefault().Remove();
                    doc.Save("Users.xml");
                    Console.WriteLine("\nRemoving user..");
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
