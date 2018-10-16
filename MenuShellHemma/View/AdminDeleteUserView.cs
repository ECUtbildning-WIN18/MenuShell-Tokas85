using System;
using System.Linq;
using System.Xml.Linq;

namespace MenuShellHemma.View
{
    class AdminDeleteUserView
    {
        public virtual void Display()
        {
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

            doc.Descendants("User").Where(p => p.Attribute("username").Value == username).FirstOrDefault().Remove();

            doc.Save("Users.xml");

        }
    }
}
