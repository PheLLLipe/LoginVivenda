using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LoginVivenda.Data;
using LoginVivenda.Models;

namespace LoginVivenda.Pages.Curriculo
{
    public class DeleteModel : PageModel
    {
        private readonly LoginVivenda.Data.LoginVivendaContext _context;

        public DeleteModel(LoginVivenda.Data.LoginVivendaContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Candidato Candidato { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Candidatos == null)
            {
                return NotFound();
            }

            var candidato = await _context.Candidatos.FirstOrDefaultAsync(m => m.Id == id);

            if (candidato == null)
            {
                return NotFound();
            }
            else 
            {
                Candidato = candidato;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Candidatos == null)
            {
                return NotFound();
            }
            var candidato = await _context.Candidatos.FindAsync(id);

            if (candidato != null)
            {
                Candidato = candidato;
                _context.Candidatos.Remove(Candidato);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
