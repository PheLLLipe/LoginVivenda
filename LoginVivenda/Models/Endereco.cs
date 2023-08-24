using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginVivenda.Models
{
    [Table("Endereço")]
    public class Endereco
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo \"{0}\" é obrigatorio")]
        [StringLength(8)]
        public string? CEP { get; set; }

        [Required(ErrorMessage = "Campo \"{0}\" é obrigatorio")]
        [StringLength(2)]
        public string? UF { get; set;}

        [Required(ErrorMessage = "Campo \"{0}\" é obrigatorio")]
        [StringLength(30)]
        public string? Cidade { get; set;}

        [Required(ErrorMessage = "Campo \"{0}\" é obrigatorio")]
        [StringLength(40)]
        public string? Bairro { get; set;}

        [Required(ErrorMessage = "Campo \"{0}\" é obrigatorio")]
        [StringLength(65)]
        public string? Rua { get; set;}

        [StringLength(6)]
        public string? Numero { get; set; }

        [StringLength(25)]
        public string? Complemento { get; set;}
    }
}
