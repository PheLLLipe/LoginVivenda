using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginVivenda.Models
{
    [Table("Empresa")]
    public class Empresa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo \"{0}\" é obrigatorio")]
        [StringLength(60)]
        public string? Nome { get; set;}

        [Required(ErrorMessage = "Campo \"{0}\" é obrigatorio")]
        [StringLength(20)]
        public string? CNPJ { get; set; }

        [Required(ErrorMessage = "Campo \"{0}\" é obrigatorio")]
        [StringLength(10)]

        public string? Telefone { get; set;}

        [Required(ErrorMessage = "Campo \"{0}\" é obrigatorio")]
        [StringLength(50)]
        public string? Email { get; set;}

        [StringLength(11)]
        public string? Contato { get; set;}

        public Endereco? Endereco { get; set; }
    }
}

