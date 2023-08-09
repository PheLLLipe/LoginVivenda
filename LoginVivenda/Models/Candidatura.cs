using System.ComponentModel.DataAnnotations;

namespace LoginVivenda.Models
{
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
