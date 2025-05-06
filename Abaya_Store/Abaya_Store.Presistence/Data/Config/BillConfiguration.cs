using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using  Abaya_Store.Domain.Entities;

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

			builder.HasData(
				new Bill
				{
					Id = 1,
					BillNumber = "BILL-001",
					CustomerId = 1,
					BillDate = DateTime.Now,
					Total = 250.75m,
					Notes = "First order",
					PaymentStatus = 1 // مثلا 1 تعني مدفوع
				});


		}
	}
}
