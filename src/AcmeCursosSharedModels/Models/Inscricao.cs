using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace AcmeCursos.Models
{
    [Table("Inscricao")]
    [DataContract(IsReference = true)]
    public class Inscricao  : GenericEntity
    {
        [DataMember]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Estudante")]
        [DataMember]
        public int EstudanteId { get; set; }

        [Required]
        [Display(Name = "Curso")]
        [DataMember]
        public int CursoId { get; set; }

        [Required]
        [Display(Name = "Data de Inscrição")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataMember]
        public DateTime DataInscricao { get; set; }

        [DataMember]
        public virtual Estudante Estudante { get; set; }
        [DataMember]
        public virtual Curso Curso { get; set; }

        public override int GetId()
        {
            return this.Id;
        }
    }
}
