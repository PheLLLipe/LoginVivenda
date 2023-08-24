using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace LoginVivenda.Models
{
    [Table ("Candidato")]
    public class Candidato
    {
       public int Id { get; set; }

       [Required(ErrorMessage = "Campo \"{0}\" é obrigatorio")]
       [StringLength(70)]
       [Display(Name = "Nome do Candidato")]
       public string? Name { get; set; }

       [Required(ErrorMessage = "Campo \"{0}\" é obrigatorio")]
       [StringLength(11)]
       public string? CPF { get; set; }

       [Required(ErrorMessage = "Campo \"{0}\" é obrigatorio")]
       public CurriculoEstado Civil { get; set; }

       [Required(ErrorMessage = "Campo \"{0}\" é obrigatorio")]
       [Display(Name = "Data de Nascimento")]
       public DateTime LoadedFromDatabase { get; set; }

       [Required]
       public CurriculoSexo Genero { get; set; }

       [Required(ErrorMessage = "Campo \"{0}\" é obrigatorio")]
       [StringLength(11)]
       [Display(Name = "Telefone 1")]
       public string? Telefone { get; set; }

       [StringLength(11)]
       [Display(Name = "Telefone 2")]
       public string? Telefone2 { get; set; }

       [Required(ErrorMessage = "Campo \"{0}\" é obrigatorio")]
       [StringLength(25)]
       public string? Nacionalidade { get; set; }

       [Required(ErrorMessage = "Campo \"{0}\" é obrigatorio")]
       public CurriculoDef Deficiencia { get; set; }

       [StringLength(40)]
       [Display (Name = "Qual ?")]
       public string? Qual {get; set; }

       [StringLength (200)]
       public string? Objetivo { get; set;}

       [StringLength(200)]
       public string? Habilidades { get; set;}

       public ICollection<Formacao> Formacao { get; set; } = new List<Formacao>();

       [Required(ErrorMessage = "Campo \"{0}\" é obrigatorio")]
       public Endereco? Endereco { get; set; }

       [Display(Name = "Curriculo/PDF")]
       public string? CurriculoPdf { get; set; }
        
       [Display(Name = "Carta de Apresentação/PDF")]
       public string? CartaPDF { get; set; }
    }
}

public enum CurriculoEstado { Solteiro, Casado, Viúvo, Divorciado }
public enum CurriculoSexo { Masculino, Feminino, Outro }
public enum CurriculoDef { Sim, Nao }
