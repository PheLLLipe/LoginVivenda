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
    public class IndexModel : PageModel
    {
        private readonly LoginVivenda.Data.LoginVivendaContext _context;

        public IndexModel(LoginVivenda.Data.LoginVivendaContext context)
        {
            _context = context;
        }

        public IList<Candidato> Candidato { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Candidatos != null)
            {
                Candidato = await _context.Candidatos.ToListAsync();
            }
        }
    }
}
