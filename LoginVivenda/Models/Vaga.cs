using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginVivenda.Models
{
    [Table("Vagas")]
    public class Vaga
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo \"{0}\" é obrigatorio")]
        [StringLength(5, ErrorMessage = "Caracteres em excesso")]
        public string? Horario { get; set; }

        [Required]
        [StringLength(50)]
        public string? Cargo { get; set;}

        public Empresa? Empresas;
    }
}
