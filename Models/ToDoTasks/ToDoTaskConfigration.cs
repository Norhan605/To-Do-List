using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskProject.Models.ToDoTasks
{
    public class ToDoTaskConfigration : IEntityTypeConfiguration<ToDoTask>
    {
        public void Configure(EntityTypeBuilder<ToDoTask> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x=>x.Description).HasMaxLength(70);
        }
    }
}
