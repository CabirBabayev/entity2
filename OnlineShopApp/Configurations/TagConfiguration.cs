using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopApp.Configurations
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> entity)
        {
            entity.Property(x => x.Name)
            .HasMaxLength(50)
            .IsRequired();

            entity.HasIndex(x => x.Name)
            .IsUnique();
        }
    }
}