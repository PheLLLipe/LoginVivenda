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
    public class DetailsModel : PageModel
    {
        private readonly LoginVivenda.Data.LoginVivendaContext _context;

        public DetailsModel(LoginVivenda.Data.LoginVivendaContext context)
        {
            _context = context;
        }

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
    }
}
