using Microsoft.EntityFrameworkCore;
using backend.Domain.Entities;
using backend.Domain.Data;

namespace backend.Domain.Repositories {
  public class UsuarioRepository : IUsuarioRepository {
    private readonly DataContext _context;

    public UsuarioRepository(DataContext context) {
      _context = context;
    }

    public void SaveChanges() {
      _context.SaveChanges();
    }

    public void Add<T>(T entity) where T : class{
      _context.Add<T>(entity);
    }

    public void Update<T>(T entity) where T : class {
      _context.Update<T>(entity);
    }

    public List<Usuario> Lista() {
      return _context.Usuarios.ToList();
    }

    public void Remove(Guid IdUsuario) {
      _context.Remove(_context.Usuarios.Single(usuario => usuario.Id == IdUsuario));
    }
  }
}