using backend.Domain.Command.Responses;
using backend.Domain.Command.Requests;

namespace backend.Domain.Handlers {
  public interface ICriaUsuarioHandler {
    CriaUsuarioResponse Handle(CriaUsuarioRequest command);
  }
}