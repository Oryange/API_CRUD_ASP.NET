using Microsoft.EntityFrameworkCore;
using MyTodo.Models;

namespace MyTodo.Data
{
  // arquivo que faz o depara: classe 'x' vai ser tabela 'z' no banco
  public class AppDbContext : DbContext
  {
    public DbSet<Todo> Todos { get; set; }

    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlite(connectionString: "DataSource=app.db; Cache=Shared");
  }
}
