using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LoginVivenda.Data;
using LoginVivenda.Models;

namespace LoginVivenda.Pages.Empresas
{
    public class IndexModel : PageModel
    {
        private readonly LoginVivenda.Data.LoginVivendaContext _context;

        public IndexModel(LoginVivenda.Data.LoginVivendaContext context)
        {
            _context = context;
        }

        public IList<Empresa> Empresa { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Empresas != null)
            {
                Empresa = await _context.Empresas.ToListAsync();
            }
        }
    }
}
