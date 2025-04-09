using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AbayaStore.Models;

namespace AbayaStore.Configurations
{
	public class BillConfiguration : IEntityTypeConfiguration<Bill>
	{
		public void Configure(EntityTypeBuilder<Bill> builder)
		{
			builder.HasKey(b => b.Id);
			builder.Property(b => b.BillNumber).IsRequired().HasMaxLength(50);
			builder.Property(b => b.Total).IsRequired();
			builder.Property(b => b.Notes).HasMaxLength(1000);

			builder.ToTable("Bills");

		}
	}
}
