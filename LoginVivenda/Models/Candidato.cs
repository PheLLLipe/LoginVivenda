using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginVivenda.Models
{
    [Table ("Candidato")]
    public class Candidato
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo \"{0}\" é obrigatorio")]
        [StringLength(100, ErrorMessage = "Caracteres em excesso")]
        [Display(Name = "Nome do Candidato")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Campo \"{0}\" é obrigatorio")]
        [StringLength(11)]
        public string? CPF { get; set; }

         // Espaço para o curriculo PDF
         // Espaço para a carta de apresentação PDF

    }
}
