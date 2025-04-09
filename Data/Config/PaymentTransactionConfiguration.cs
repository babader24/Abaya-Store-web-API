using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
	}
}

