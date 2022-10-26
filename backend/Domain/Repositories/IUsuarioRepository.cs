using backend.Domain.Entities;

namespace backend.Domain.Repositories {
  public interface IUsuarioRepository {

    void SaveChanges();
    
    void Add<T>(T entity) where T : class;

    void Update<T>(T entity) where T : class;

    List<Usuario> Lista();

    void Remove(Guid IdUsuario);

  }
}