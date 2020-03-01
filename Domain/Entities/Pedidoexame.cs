using System;

namespace Domain.Entities
{
    public partial class Pedidoexame
    {
        protected Pedidoexame() { }

        public Pedidoexame(DateTime dataRealizacao, string hipotese, int idPaciente, int idExame, int idMedico)
        {
            this.DataEmissao = DateTime.Now;
            this.DataRealizacao = dataRealizacao;
            this.Hipotese = hipotese;
            this.IdPaciente = idPaciente;
            this.IdExame = idExame;
            this.IdMedico = idMedico;
        }

        public int Id { get; private set; }
        public DateTime DataEmissao { get; private set; }
        public DateTime DataRealizacao { get; private set; }
        public string Hipotese { get; private set; }
        public int IdPaciente { get; private set; }
        public int IdExame { get; private set; }
        public int IdMedico { get; private set; }

        public virtual Exame IdExameNavigation { get; private set; }
        public virtual Medico IdMedicoNavigation { get; private set; }
        public virtual Paciente IdPacienteNavigation { get; private set; }
        public virtual Registroexame IdRegistroexameNavigation { get; private set; }

        public void Remarcar(DateTime novaData) => this.DataRealizacao = novaData;
    }
}
