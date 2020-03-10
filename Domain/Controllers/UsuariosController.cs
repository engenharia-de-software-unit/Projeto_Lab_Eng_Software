using Domain.Interfaces.Uow;
using System.Web.Mvc;
using Domain.Entities;
using System.Linq;
using System.Collections.Generic;

namespace Domain.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsuariosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //Método de Cadastrar(Usuario usuario)
        public bool Cadastrar(Usuario usuario) {
            _unitOfWork.RepositoryUsuario.Adicionar(usuario);
            _unitOfWork.Commit();
            return true;
        }

        //Método de Autentiar(string email, string senha)
        public bool Autenticar (string email, string senha) {
           return _unitOfWork.RepositoryUsuario.Obter().Where(u => u.Email.Equals(email) && u.Senha.Equals(senha)).FirstOrDefault() != null;
        }

        //Método de ObterTodos()
        public List<Usuario> ObterTodos() {
            return _unitOfWork.RepositoryUsuario.Obter().ToList();
        }

        //Método de ObterPorId(int id)
        public Usuario ObterPorId (int id) {
            return _unitOfWork.RepositoryUsuario.Obter().Where(u => u.Id == id).FirstOrDefault();
        }

        //Método de AlterarSenha(string novaSenha)
        public void AlterarSenha(int id, string novaSenha) {
            var usuario = ObterPorId(id);
            if (usuario != null) {
                usuario.AlterarSenha(novaSenha);
                _unitOfWork.RepositoryUsuario.Atualizar(usuario);
                _unitOfWork.Commit();
            }
        }
    }
}
