using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginVivenda.Models
{
    [Table("Candidatura")]
    public class Candidatura
    {
        public int Id { get; set; }
        public Vaga? Vaga { get; set; }

        public Candidato? Candidato { get; set; }

        [StringLength(100)]
        [Display (Name = "Observação")]
        public string? Mensagem { get; set; }

        public CandidaturaStatus Status { get; set; }

        public CandidaturaNota Notas { get; set; }


    }
}

public enum CandidaturaStatus { Sim, Não }
public enum CandidaturaNota {  }

// Adicionar um random para as notas !!!