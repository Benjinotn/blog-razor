using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp;

public class IndexModel : PageModel
{
    public LocalRedirectResult OnGet()
    {
        return new LocalRedirectResult("~/Blog");
    }

}