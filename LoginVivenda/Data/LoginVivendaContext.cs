using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LoginVivenda.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace LoginVivenda.Data
{
    public class LoginVivendaContext : IdentityDbContext<User>
    {
        public LoginVivendaContext(DbContextOptions<LoginVivendaContext> options) : base(options) { }

        public DbSet<Candidato>? Candidatos { get; set; }

        public DbSet<Candidatura>? Candidaturas { get; set; }

        public DbSet<Empresa>? Empresas { get; set; }

        public DbSet<Endereco>? Enderecos { get; set; }

        public DbSet<Formacao>? Formacaos { get; set; }

        public DbSet<Vaga>? Vagas { get; set; }
    }
}
