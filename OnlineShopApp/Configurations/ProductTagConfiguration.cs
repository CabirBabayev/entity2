using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopApp.Configurations
{
    public class ProductTagConfiguration : IEntityTypeConfiguration<ProductTag>
    {
        public void Configure(EntityTypeBuilder<ProductTag> entity)
        {
            entity.HasKey(pt => new { pt.TagId, pt.ProductId });

            entity.HasOne(pt => pt.Product)
                  .WithMany(t => t.ProductTags)
                  .HasForeignKey(pt => pt.ProductId);

            entity.HasOne(pt => pt.Tag)
                  .WithMany(t => t.ProductTags)
                  .HasForeignKey(pt => pt.TagId);
        }
    }
}