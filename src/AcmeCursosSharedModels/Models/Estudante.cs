using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;

namespace AcmeCursos.Models
{
    [DataContract(IsReference = true)]
    public class Estudante : GenericEntity
    {
        [DataMember]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required]
        [DataMember]
        public string Nome { get; set; }

        [Display(Name = "Sobrenome")]
        [Required]
        [DataMember]
        public string Sobrenome { get; set; }

        [Display(Name = "Data de Matricula")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataMember]
        public DateTime DataMatricula { get; set; }

        [DataMember]
        [UIHint("Inscricoes")]
        public virtual ICollection<Inscricao> Inscricoes { get; set; }

        public override int GetId()
        {
            return this.Id;
        }
    }
}