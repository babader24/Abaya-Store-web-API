using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Abaya_Store.Domain.Entities;
namespace AbayaStore.Configurations
{
	public class PersonConfiguration : IEntityTypeConfiguration<Person>
	{
		public void Configure(EntityTypeBuilder<Person> builder)
		{
			builder.HasKey(p => p.Id);
			builder.Property(p => p.FirstName).IsRequired().HasMaxLength(100);
			builder.Property(p => p.LastName).IsRequired().HasMaxLength(100);
			builder.Property(p => p.Email).IsRequired().HasMaxLength(255);
			builder.Property(p => p.Phone).IsRequired().HasMaxLength(15);
			builder.Property(p => p.Address).HasMaxLength(255);
			builder.Property(p => p.Image).HasMaxLength(255);
			builder.Property(p => p.Password).IsRequired().HasMaxLength(255);
			builder.Property(p => p.Role).IsRequired();
			builder.Property(p => p.status).IsRequired();

			builder.UseTpcMappingStrategy();
		}
	}
}

