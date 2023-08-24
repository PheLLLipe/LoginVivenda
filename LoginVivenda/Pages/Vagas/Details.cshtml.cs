using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LoginVivenda.Data;
using LoginVivenda.Models;

namespace LoginVivenda.Pages.Vagas
{
    public class DetailsModel : PageModel
    {
        private readonly LoginVivenda.Data.LoginVivendaContext _context;

        public DetailsModel(LoginVivenda.Data.LoginVivendaContext context)
        {
            _context = context;
        }

      public Vaga Vaga { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Vagas == null)
            {
                return NotFound();
            }

            var vaga = await _context.Vagas.FirstOrDefaultAsync(m => m.Id == id);
            if (vaga == null)
            {
                return NotFound();
            }
            else 
            {
                Vaga = vaga;
            }
            return Page();
        }
    }
}
