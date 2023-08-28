using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoginVivenda.Pages
{
    public class RedirIndexModel : PageModel
    {

        public IActionResult OnGet()
        {
            return Redirect("/login");
        }
    }
}
