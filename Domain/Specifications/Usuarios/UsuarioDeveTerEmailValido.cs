﻿using Domain.Entities;
using DomainValidation.Interfaces.Specification;
using Infra.Validations.Usuarios;

namespace Domain.Specifications.Usuarios
{
    public class UsuarioDeveTerEmailValido : ISpecification<Usuario>
    {
        public bool IsSatisfiedBy(Usuario usuario)
        {
            return EmailValidation.Validate(usuario.Email);
        }
    }
}
