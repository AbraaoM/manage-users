using backend.Domain.Queries.Responses;
using backend.Domain.Entities;
using backend.Domain.Repositories;

namespace backend.Domain.Handlers {
  public class ListaUsuariosHandler {
    IUsuarioRepository _repository;

    public ListaUsuariosHandler (IUsuarioRepository repository) {
      repository = _repository;
    }

    public List<Usuario> Handle() {
      return _repository.Lista();
    }

  }
}