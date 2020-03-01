namespace Domain.Entities
{
    public class Arquivo
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Caminho { get; private set; }

        public int IdRegistroExame { get; private set; }
        public virtual RegistroExame RegistroExame { get; private set; }

        protected Arquivo() { }

        public Arquivo(string nome, string caminho, int idRegistro)
        {
            Nome = nome;
            Caminho = caminho;
            IdRegistroExame = idRegistro;
        }
    }
}
