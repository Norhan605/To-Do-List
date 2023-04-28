using Microsoft.EntityFrameworkCore;
using TaskProject.Models.ToDoTasks;

namespace TaskProject.Models
{
    public static class RelationalMapping
    {
        public static void MapRelations(this ModelBuilder builder)
        {
            builder.Entity<ToDoTask>().HasOne(x => x.Category).WithMany(x => x.Tasks)
                .HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ToDoTask>().HasOne(x=>x.User).WithMany(x => x.Tasks)
                .HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
