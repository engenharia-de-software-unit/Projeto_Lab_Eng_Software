namespace Domain.Entities
{
    public partial class Administrador
    {
        protected Administrador() { }

        public Administrador(string nome, int idUsuario)
        {
            this.Nome = nome;
            this.IdUsuario = idUsuario;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int IdUsuario { get; private set; }
        public virtual Usuario Usuario { get; private set; }
    }
}
