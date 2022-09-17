namespace DependencyInjectionDotNetCore6.Services
{
    public interface IAccountService
    {
        string login(string username, string password);
    }
}
