using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Abaya_Store.Domain.Entities;
namespace AbayaStore.Configurations
{
	public class OrderDetaileConfiguration : IEntityTypeConfiguration<OrderDetaile>
	{
		public void Configure(EntityTypeBuilder<OrderDetaile> builder)
		{
			builder.HasKey(o => o.Id);
			builder.Property(o => o.UnitPrice).IsRequired();
			builder.Property(o => o.Amount).IsRequired();
			builder.HasOne(o => o.Bill)
				   .WithMany()
				   .HasForeignKey(o => o.BillId);

			builder.HasOne(o => o.Product)
				   .WithMany()
				   .HasForeignKey(o => o.ProductId);

			builder.ToTable("OrderDetailes");

		}
	}
}
