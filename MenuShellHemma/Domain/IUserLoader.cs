using System.Collections.Generic;

namespace MenuShellHemma.Domain
{
    interface IUserLoader
    {
        List<User> LoadUsers();
    }
}
