using Microsoft.EntityFrameworkCore;
using backend.Domain.Entities;

namespace backend.Domain.Data {
  public class DataContext : DbContext {
    public DataContext (DbContextOptions<DataContext> options): base(options){}

    public DbSet<Usuario> Usuarios {get; set;}

  }
}