using Domain.Entities;
using Domain.Specifications.Usuarios;
using DomainValidation.Validation;

namespace Domain.Validations.Usuarios
{
    public class UsuarioValidarDados : Validator<Usuario>
    {
        public UsuarioValidarDados()
        {
            var emailInvalido = new UsuarioDeveTerEmailValido();
            var senhaInvalida = new UsuarioDeveTerSenhaValida();

            base.Add("emailInvalido", new Rule<Usuario>(emailInvalido, "Email inválido!"));
            base.Add("senhaInvalida", new Rule<Usuario>(senhaInvalida, "Senha deve ter conter letras e números!"));
        }
    }
}
