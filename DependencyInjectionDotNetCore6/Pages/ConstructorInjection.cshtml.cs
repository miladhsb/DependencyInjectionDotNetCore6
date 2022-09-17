using DependencyInjectionDotNetCore6.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DependencyInjectionDotNetCore6.Pages
{
    public class ConstructorInjectionModel : PageModel
    {
        private readonly IAccountService _accountService;

        public ConstructorInjectionModel(IAccountService accountService)
        {
            this._accountService = accountService;
        }
        public IActionResult OnGet()
        {
            ViewData["login"] = _accountService.login("admin", "123");
            return Page();
        }
    }
}
