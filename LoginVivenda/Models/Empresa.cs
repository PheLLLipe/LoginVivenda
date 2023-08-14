using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginVivenda.Models
{
	[Table("empresa")]

	public class Empresa
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string? Nome { get; set;}

        [Required]
        [StringLength(20)]
        public string? CNPJ { get; set; }

        [Required]
        [StringLength(10)]

        public string? Telefone { get; set;}

        [Required]
        [StringLength(50)]
        public string? Email { get; set;}

        [Required]
        [StringLength(11)]
        public string? Contato { get; set;}

        public Endereco? Endereco { get; set; }
    }
}
