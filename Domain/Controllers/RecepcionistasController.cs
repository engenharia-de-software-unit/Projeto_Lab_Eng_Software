using Domain.Interfaces.Uow;
using Domain.Entities;
using System.Linq;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Domain.Controllers
{
    public class RecepcionistasController : Controllers
    {
        private readonly IUnitOfWork _unitOfWork;

        public RecepcionistasController(IUnitOfWork unitOfWork) {
            _unitOfWork = unitOfWork;
        }

        //Método de cadastrar(Recepcionista recepcionista)
        public Recepcionista Cadastrar(Recepcionista recepcionista) {
            _unitOfWork.RepositoryRecepcionista.Adicionar(recepcionista);
            _unitOfWork.Commit();
            return recepcionista;
        }

        //Método de Autenticar(string nome, int id)
        public bool Autenticar(string nome, int id) {
            return _unitOfWork.RepositoryRecepcionista.Obter().Where(r => r.Nome.Equals(nome) && (r.IdUsuario == id)).FirstOrDefault() != null;
        }

        //Método de ObterTodos()
        public List<Recepcionista> ObterTodos() {
            return _unitOfWork.RepositoryRecepcionista.Obter().ToList();
        }

        //Método de ObterPorId
        public Recepcionista ObterPorId(int id) {
            return _unitOfWork.RepositoryRecepcionista.Obter().Where(r => r.Id == id).FirstOrDefault();
        }
    }
}