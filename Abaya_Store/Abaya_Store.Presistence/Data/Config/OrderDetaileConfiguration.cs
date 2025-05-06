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

			builder.HasData(
				  new OrderDetaile
				  {
					  Id = 1,
					  ProductId = 1,
					  Quantity = 2,
					  UnitPrice = 100.25m,
					  Amount = 200.50m,
					  BillId = 1
				  },
				  new OrderDetaile
				  {
					  Id = 2,
					  ProductId = 2,
					  Quantity = 1,
					  UnitPrice = 50.25m,
					  Amount = 50.25m,
					  BillId = 1
			});


		}
	}
}
