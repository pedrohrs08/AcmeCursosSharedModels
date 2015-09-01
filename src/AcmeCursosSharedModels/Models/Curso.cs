using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;

namespace AcmeCursos.Models
{
    [Table("Curso")]
    [DataContract(IsReference = true)]
    public class Curso : GenericEntity
    {
        [DataMember]
        public int Id { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 0)]
        [DataMember]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        [DataMember]
        public string Descricao { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data limite para inscrição")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataMember]
        public DateTime DataLimiteInscricao { get; set; }

        [DataMember]
        [UIHint("Incscricoes")]
        public virtual ICollection<Inscricao> Inscricoes { get; set; }
        [DataMember]
        [UIHint("Professores")]
        public virtual ICollection<Professor> Professores { get; set; }


        public override int GetId()
        {
            return this.Id;
        }
    }
}