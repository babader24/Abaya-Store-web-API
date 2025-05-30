﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Abaya_Store.Domain.Entities;
namespace AbayaStore.Configurations
{
	public class OfferProductConfiguration : IEntityTypeConfiguration<OfferProduct>
	{
		public void Configure(EntityTypeBuilder<OfferProduct> builder)
		{
			builder.HasKey(op => op.Id);

			builder.HasOne(op => op.Offer)
				   .WithMany(o => o.Products)
				   .HasForeignKey(op => op.OfferId);

			builder.HasOne(op => op.Product)
				   .WithMany()
				   .HasForeignKey(op => op.ProductId);

			builder.ToTable("OfferProducts");

			builder.HasData(
				new OfferProduct { Id = 1, OfferId = 1, ProductId = 1 },
				new OfferProduct { Id = 2, OfferId = 2, ProductId = 2 });

		}
	}
}
