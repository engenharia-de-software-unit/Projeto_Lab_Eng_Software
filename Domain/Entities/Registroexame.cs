using System;

namespace Domain.Entities
{
    public partial class Registroexame
    {
        protected Registroexame() { }

        public Registroexame(string arquivos, int idPedidoExame)
        {
            this.Data = DateTime.Now;
            this.Arquivos = arquivos;
            this.Status = false;
            this.IdPedidoExame = idPedidoExame;
        }

        public int Id { get; private set; }
        public DateTime Data { get; private set; }
        public string Arquivos { get; private set; }
        public string Laudo { get; private set; }
        public Boolean Status { get; private set; }
        public int IdDocente { get; private set; }
        public int IdResidente { get; private set; }
        public int IdPedidoExame { get; private set; }

        public virtual Docente IdDocenteNavigation { get; private set; }
        public virtual Pedidoexame IdPedidoExameNavigation { get; private set; }
        public virtual Residente IdResidenteNavigation { get; private set; }

        public void EmitirLaudo(int idResidente, string laudo)
        {
            this.IdResidente = idResidente;
            this.Laudo = laudo;
        }

        public void ConfirmarLaudo(int idDocente, string laudo)
        {
            this.IdDocente = idDocente;
            this.Laudo = laudo;
            this.Status = true;
        }

    }
}
