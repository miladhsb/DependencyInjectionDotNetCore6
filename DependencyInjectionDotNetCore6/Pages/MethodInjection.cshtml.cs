using DependencyInjectionDotNetCore6.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DependencyInjectionDotNetCore6.Pages
{
    public class MethodInjectionModel : PageModel
    {
        public void OnGet([FromServices] IAccountService accountService)
        {
            ViewData["login"] = accountService.login("admin", "123");
        }
    }
}
