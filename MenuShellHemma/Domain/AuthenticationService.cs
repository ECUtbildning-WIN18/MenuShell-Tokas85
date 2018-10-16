using System.Linq;

namespace MenuShellHemma.Domain
{
    class AuthenticationService : IAuthenticationService
    {
        public User Authenticate(string username, string password)
        {
            var userLoader = new UserLoader();

            var users = userLoader.LoadUsers();

            return users.FirstOrDefault(x => x.Username == username && x.Password == password);
        }
    }
}
