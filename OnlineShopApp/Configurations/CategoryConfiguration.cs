using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace OnlineShopApp.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> entity)
        {
            entity
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            entity.Property(x => x.Name)
            .HasMaxLength(100)
            .IsRequired();

            entity.Property(x => x.Description)
            .HasMaxLength(500);

            entity.HasIndex(x => x.Name)
            .IsUnique();
        }
    }
}