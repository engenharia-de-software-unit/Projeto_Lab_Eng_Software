using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Specifications.Usuarios;
using DomainValidation.Validation;

namespace Domain.Validations.Usuarios
{
    public class UsuarioValidarCadastro : Validator<Usuario>
    {
        public UsuarioValidarCadastro(IRepository<Usuario> repository)
        {
            var emailDuplicado = new UsuarioDeveTerEmailUnico(repository);

            base.Add("emailDuplicado", new Rule<Usuario>(emailDuplicado, "Email já utilizado por outro usuário!"));
        }
    }
}
