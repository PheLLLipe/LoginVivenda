﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace LoginVivenda.Models
{
    [Table("Formação")]
    public class Formacao
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo \"{0}\" é obrigatorio")]
        [StringLength(70)]
        public string? Instituto { get; set; }

        [Required(ErrorMessage = "Campo \"{0}\" é obrigatorio")]
        [StringLength(50)]
        [Display (Name = "Nome do Curso")]
        public string? Nome { get; set; }

        [Display(Name = "Data Inicio")]
        public DateTime DataIni
        { get; set; }

        [Display(Name = "Data Conclusão")]
        public DateTime  DataFim { get; set; }

        [Display(Name = "Estado do Curso")]
        public FormacaoEstado Curso { get; set; }

        [StringLength(70)]
        [Display (Name = "Cidade (UF)")]
        public string? Cidade { get; set; }

    }
}

public enum FormacaoEstado { Cursando, Concluido, Incompleto}

// Falta Adicionar as Notas Papa