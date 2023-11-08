using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp;

public class IndexModel : PageModel
{
    public RedirectToPageResult OnGet()
    {
        return new RedirectToPageResult("/Blog");
    }

}