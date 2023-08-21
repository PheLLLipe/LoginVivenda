using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoginVivenda.Pages
{
	public class AdmIndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		public AdmIndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{

		}
	}
}