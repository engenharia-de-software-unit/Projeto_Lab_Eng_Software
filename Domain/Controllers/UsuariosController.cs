using Domain.Interfaces.Uow;
using System.Web.Mvc;

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
        //Método de Autentiar(string email, string senha)
        //Método de ObterTodos()
        //Método de ObterPorId(int id)
        //Método de AlterarSenha(string novaSenha)
    }
}
