﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AbayaStore.Models;

namespace AbayaStore.Configurations
{
	public class ProductConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.HasKey(p => p.Id);
			builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
			builder.Property(p => p.Image).IsRequired().HasMaxLength(255);
			builder.Property(p => p.UnitPrice).IsRequired();
			builder.Property(p => p.Description).HasMaxLength(1000);
			builder.Property(p => p.Size).IsRequired().HasMaxLength(10);
			builder.Property(p => p.QuantityAvailable).IsRequired();

			builder.HasOne(p => p.Category)
				   .WithMany(c => c.Products)
				   .HasForeignKey(p => p.CategoryId);

			builder.ToTable("Products");

		}
	}
}
