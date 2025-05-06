using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Abaya_Store.Domain.Entities;

namespace AbayaStore.Configurations
{
	public class CategoryConfiguration : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasKey(c => c.Id);
			builder.Property(c => c.Name).IsRequired().HasMaxLength(100);

			builder.ToTable("Categories");

			builder.HasData(
				new Category { Id = 1, Name = "Electronics" },
				new Category { Id = 2, Name = "Clothing" },
				new Category { Id = 3, Name = "Books" }
			);
		}
	}
}
