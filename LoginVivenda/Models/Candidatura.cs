using System.ComponentModel.DataAnnotations;

namespace LoginVivenda.Models
{
    public class Candidatura
    {
        public int Id { get; set; }

        [Required]
        [StringLength()]
    }
}
