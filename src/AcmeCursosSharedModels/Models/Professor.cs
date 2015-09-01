using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;

namespace AcmeCursos.Models
{
    [Table("Professor")]
    [DataContract(IsReference = true)]
    public class Professor : GenericEntity
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [Required]
        public string Nome { get; set; }

        [Required]
        [DataMember]
        public string Sobrenome { get; set; }

        [Display(Name = "Titulação")]
        [DataMember]
        public string Titulacao { get; set; }

        [DataMember]
        [UIHint("Cursos")]
        public virtual ICollection<Curso> Cursos { get; set; }

        public override int GetId()
        {
            return this.Id;
        }
    }
}