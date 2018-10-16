﻿using System.Collections.Generic;
using System.Xml.Linq;

namespace MenuShellHemma.Domain
{
    class UserLoader : IUserLoader
    {
        public List<User> LoadUsers()
        {
            var users = new List<User>();

            var doc = XDocument.Load("Users.xml");

            var root = doc.Root;
            
            foreach (var element in root.Elements())
            {
                var username = element.Attribute("username").Value;
                var password = element.Attribute("password").Value;
                var role = element.Attribute("role").Value;

                users.Add(new User(username, password, role));

            }
            
            return users;
        }
    }
}
