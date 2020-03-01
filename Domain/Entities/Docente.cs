using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Docente
    {
        protected Docente() { }

        public Docente(string titUniversitaria, int idMedico)
        {
            this.TitUniversitaria = titUniversitaria;
            this.IdMedico = idMedico;
        }

        public int Id { get; private set; }
        public string TitUniversitaria { get; private set; }
        public int IdMedico { get; private set; }

        public virtual Medico IdMedicoNavigation { get; private set; }
        public virtual ICollection<Registroexame> Registroexame { get; private set; }
    }
}
