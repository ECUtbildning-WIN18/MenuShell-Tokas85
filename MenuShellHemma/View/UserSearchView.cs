using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using MenuShellHemma.Domain.Database;

namespace MenuShellHemma.View
{
    class UserSearchView
    {

        public void Display()
        {
            var adminMainView = new AdminMainView();

            Console.WriteLine("# Search user");
            Console.WriteLine();

            Console.Write("Search by username: ");
            
            var searchInput1 = "/Users/User[@username='";
            var searchInput2 = Console.ReadLine();
            var searchInput3 = "']";

            Console.WriteLine();
            Console.WriteLine("Searching...");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("Search results:");
            Console.WriteLine();


            var doc = new XmlDocument();
            doc.Load("Users.xml");
            var nodeList = doc.SelectNodes(searchInput1 + searchInput2 + searchInput3);
            foreach (XmlNode node in nodeList)
            {   
                Console.WriteLine("Username: " + node.Attributes["username"].Value);
                Console.WriteLine("Role: " + node.Attributes["role"].Value);
            }

            Console.WriteLine();
            Console.WriteLine("Press any button to return to menu..");
            Console.ReadKey();
            Console.WriteLine("Returning to menu..");
            Thread.Sleep(1000);
            Console.Clear();
            adminMainView.Display();



        }
    }
}
