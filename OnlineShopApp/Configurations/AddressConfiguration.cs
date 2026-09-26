using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopApp.Configurations
{
    public class AddressConfiguration: IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> entity)
        {
            entity.Property(x => x.Country)
            .HasMaxLength(100)
            .IsRequired();

            entity.Property(x => x.City)
            .HasMaxLength(100)
            .IsRequired();

            entity.Property(x => x.Street)
            .HasMaxLength(200)
            .IsRequired();

            entity.Property(x => x.House)
            .HasMaxLength(20)
            .IsRequired();

            entity.Property(x => x.Apartment)
            .HasMaxLength(20);

            entity.Property(x => x.PostalCode)
            .HasMaxLength(20)
            .IsRequired();
        }
    }
}