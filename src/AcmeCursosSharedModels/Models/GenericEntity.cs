using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace AcmeCursos.Models
{
    [DataContract(IsReference = true)]
    public abstract class GenericEntity
    {
        public abstract int GetId(); 
    }
}