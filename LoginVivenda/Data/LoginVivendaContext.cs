using Microsoft.EntityFrameworkCore;
using LoginVivenda.Models;

namespace LoginVivenda.Data
{
    public class LoginVivendaContext:DbContext
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
