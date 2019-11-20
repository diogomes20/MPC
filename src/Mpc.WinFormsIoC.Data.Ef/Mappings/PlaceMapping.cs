using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mpc.WinFormsIoC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mpc.WinFormsIoC.Data.Ef.Mappings
{
    internal class PlaceMapping : IEntityTypeConfiguration<PlaceModel>
    {
        public void Configure(EntityTypeBuilder<PlaceModel> builder)
        {
            builder.ToTable("Place");

            builder.HasKey("Id");

            builder.Property(p => p.Id)
                .HasColumnName("Id")
                .IsRequired();
            
            builder.Property(p => p.Name)
                .HasColumnName("Name")
                .IsRequired()
                .HasMaxLength(255);
            
            builder.Property(p => p.Address)
                .HasColumnName("Address")
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(p => p.PhoneNumber)
                .HasColumnName("PhoneNumber")
                .IsRequired();
            
            builder.Property(p => p.Website)
                .HasColumnName("Website")
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(p => p.Classification)
               .HasColumnName("Classification");
        }
    }
}
