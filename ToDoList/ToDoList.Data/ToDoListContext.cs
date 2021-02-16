using Microsoft.EntityFrameworkCore;
using ToDoList.Domain.Entidades;

namespace ToDoList.Data
{
    public class ToDoListContext : DbContext

    {
        public ToDoListContext(DbContextOptions<ToDoListContext> Options) : base(Options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}