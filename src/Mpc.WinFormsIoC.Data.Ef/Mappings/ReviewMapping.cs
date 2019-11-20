using Microsoft.EntityFrameworkCore;
using Mpc.WinFormsIoC.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mpc.WinFormsIoC.Data.Ef.Mappings
{
    internal class ReviewMapping : IEntityTypeConfiguration<ReviewModel>
    {
        public void Configure(EntityTypeBuilder<ReviewModel> builder)
        {
            builder.ToTable("Review");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Id)
                .HasColumnName("Id")
                .IsRequired();

            builder.Property(r => r.PlaceId)
                .HasColumnName("PlaceId")
                .IsRequired();

            builder.Property(r => r.UserId)
                .HasColumnName("UserId")
                .IsRequired();

            builder.Property(r => r.Classification)
                .HasColumnName("Classification")
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(r => r.Comments)
                .HasColumnName("Comments")
                .IsRequired()
                .HasMaxLength(255);
            
            //Relations

            builder.HasOne<UserModel>(r => r.User)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.UserId);

            builder.HasOne<PlaceModel>(r => r.Place)
                .WithMany(p => p.Reviews)
                .HasForeignKey(r => r.PlaceId);
        }
    }
}
