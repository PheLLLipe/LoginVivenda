using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginVivenda.Models
{
	[Table("endereco")]

	public class Endereco
    {
        public int Id { get; set; }

        [Required]
        [StringLength(8)]
        public string? CEP { get; set; }

        [Required]
        [StringLength(2)]
        public string? UF { get; set;}

        [Required]
        [StringLength(30)]
        public string? Cidade { get; set;}

        [Required]
        [StringLength(40)]
        public string? Bairro { get; set;}

        [Required]
        [StringLength(65)]
        public string? Rua { get; set;}

        [StringLength(6)]
        public string? Numero { get; set; }

        [StringLength(25)]
        public string? Complemento { get; set;}
    }
}
