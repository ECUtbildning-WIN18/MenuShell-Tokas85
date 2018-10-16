using MenuShellHemma.View;

namespace MenuShellHemma
{
    class Program
    {
        static void Main(string[] args)
        {
            var loginView = new LoginView();
            loginView.Display();
        }
    }
}
