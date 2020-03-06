using System.Linq;

namespace Domain.Interfaces.Repositories
{
    public interface IRepository<Entity>
    {
        void Adicionar(Entity entity);
        IQueryable<Entity> Obter();
        void Atualizar(Entity entity);
        void Remover(Entity entity);
    }
}
