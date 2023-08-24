using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LoginVivenda.Data;
using LoginVivenda.Models;

namespace LoginVivenda.Pages.Curriculo
{
    public class CreateModel : PageModel
    {
        private readonly LoginVivenda.Data.LoginVivendaContext _context;

        public CreateModel(LoginVivenda.Data.LoginVivendaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Candidato Candidato { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Candidatos == null || Candidato == null)
            {
                return Page();
            }

            _context.Candidatos.Add(Candidato);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
