using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Residente
    {
        protected Residente() { }

        public Residente(DateTime anoResidencia, int idMedico)
        {
            AnoResidencia = anoResidencia;
            IdMedico = idMedico;
        }

        public int Id { get; private set; }
        public DateTime AnoResidencia { get; private set; }
        public int IdMedico { get; private set; }

        public virtual Medico IdMedicoNavigation { get; private set; }
        public virtual ICollection<Registroexame> Registroexame { get; private set; }
    }
}
