using Microsoft.EntityFrameworkCore;
using TaskProject.Models.Categories;
using TaskProject.Models.ToDoTasks;
using TaskProject.Models.Users;

namespace TaskProject.Models
{
    public class Context:DbContext
    {
        public DbSet<ToDoTask> ToDoTasks { get; set; }
        public DbSet<User> Users { get;set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CategoryConfigration().Configure(modelBuilder.Entity<Category>());
            new ToDoTaskConfigration().Configure(modelBuilder.Entity<ToDoTask>());
            new UserConfigration().Configure(modelBuilder.Entity<User>());
            modelBuilder.MapRelations();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog = TasksDb; Integrated Security = True; TrustServerCertificate=True");
        }
    }
}
