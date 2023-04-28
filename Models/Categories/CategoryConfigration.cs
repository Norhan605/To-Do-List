using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskProject.Models.Categories
{
    public class CategoryConfigration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
           builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasMaxLength(100);


        }
    }
}
