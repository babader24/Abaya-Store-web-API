using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Abaya_Store.Domain.Entities;

public class PaymentTransactionConfiguration : IEntityTypeConfiguration<PaymentTransaction>
{
	public void Configure(EntityTypeBuilder<PaymentTransaction> builder)
	{
		builder.ToTable("PaymentTransactions");

		builder.HasKey(p => p.Id);

		builder.Property(p => p.PaymentGateway)
			.IsRequired()
			.HasMaxLength(50);

		builder.Property(p => p.TransactionId)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(p => p.Amount)
			.HasColumnType("decimal(18,2)");

		builder.Property(p => p.IsSuccess)
			.IsRequired();

		builder.Property(p => p.ResponseMessage)
			.HasMaxLength(255);

		builder.Property(p => p.Date)
			.HasColumnType("datetime");

		builder.HasOne(p => p.Bill)
			.WithOne()
			.HasForeignKey<PaymentTransaction>(p => p.BillId)
			.OnDelete(DeleteBehavior.Cascade);

		builder.HasData(
			new PaymentTransaction
			{
				Id = 1,
				BillId = 1,
				PaymentGateway = "PayPal",
				TransactionId = "TXN123456",
				Amount = 250.75m,
				IsSuccess = true,
				ResponseMessage = "Payment Approved",
				Date = new DateTime(2025, 5, 5)
			});
	}
}

