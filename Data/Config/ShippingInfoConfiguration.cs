﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AbayaStore.Models;

namespace AbayaStore.Configurations
{
	public class ShippingInfoConfiguration : IEntityTypeConfiguration<ShippingInfo>
	{
		public void Configure(EntityTypeBuilder<ShippingInfo> builder)
		{
			builder.HasKey(s => s.Id);
			builder.Property(s => s.City).IsRequired().HasMaxLength(100);
			builder.Property(s => s.Address).IsRequired().HasMaxLength(255);
			builder.Property(s => s.PostalCode).IsRequired().HasMaxLength(20);
			builder.Property(s => s.DeliveryStatus).IsRequired();

			builder.HasOne(s => s.Bill)
				   .WithOne(b => b.ShippingInfo)
				   .HasForeignKey<ShippingInfo>(s => s.BillId);

			builder.ToTable("ShippingInfo");
		}
	}
}
