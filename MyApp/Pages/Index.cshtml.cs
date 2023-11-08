using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Pages;

public class IndexModel : PageModel
{

    private readonly IWebHostEnvironment _env;
    public IndexModel(IWebHostEnvironment env)
    {
        _env = env;
    }
    public LocalRedirectResult OnGet()
    {

        if(_env.IsDevelopment())
            return new LocalRedirectResult("~/blog");
        return new LocalRedirectResult("~/blog-razor/blog");
    }

}