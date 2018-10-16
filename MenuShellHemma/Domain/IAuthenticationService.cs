namespace MenuShellHemma.Domain
{
    interface IAuthenticationService
    {
        User Authenticate(string username, string password);
    }
}
