using System;
using System.Xml.Linq;

namespace MenuShellHemma.View
{
    class AdminAddUserView //: UserLoader , IUserLoader
    {
        public virtual void Display()
        {


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
            Console.WriteLine("Is this correct? (Y)es (N)o ");
            Console.WriteLine();
            Console.ReadKey();


            root.Add(new XElement("User",
                new XAttribute("username", username), 
                new XAttribute("password", password), 
                new XAttribute("role", role)));
            
            

            doc.Save("Users.xml");
        }
    }
}
