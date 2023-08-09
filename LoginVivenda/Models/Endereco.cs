using System.ComponentModel.DataAnnotations;

namespace LoginVivenda.Models
{
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

        [Required]
        [StringLength(6)]
        public string? Numero { get; set; }

        [StringLength(25)]
        public string? Complemento { get; set;}
    }
}
