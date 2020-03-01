namespace Domain.Entities
{
    public partial class Usuario
    {
        protected Usuario() { }

        public Usuario(string Email, string Senha)
        {
            this.Email = Email;
            this.Senha = Senha;
        }

        public int Id { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }

        public virtual Administrador Administrador { get; private set; }
        public virtual Medico Medico { get; private set; }
        public virtual Recepcionista Recepcionista { get; private set; }
    }
}
