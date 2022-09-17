namespace DependencyInjectionDotNetCore6.Services
{
    public class AccountService : IAccountService
    {
        public string login(string username, string password)
        {
          return  string.Concat(username," ",password);
        }
    }
}
