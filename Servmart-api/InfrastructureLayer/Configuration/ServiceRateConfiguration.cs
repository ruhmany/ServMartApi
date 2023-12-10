﻿using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureLayer.Configuration
{

    public class ServiceRateConfiguration : IEntityTypeConfiguration<ServiceRate>
    {
        public void Configure(EntityTypeBuilder<ServiceRate> builder)
        {
            builder.ToTable("ServiceRate", "Service");
            builder.HasKey(r => r.ID);
            builder.Property(r => r.Message).HasMaxLength(500).IsRequired();
            builder.Property(r => r.WorkQuality).IsRequired();
            builder.Property(r => r.NominateToOthers).IsRequired();
            builder.Property(r => r.RespectDeliveryTime).IsRequired();
            builder.HasOne(s => s.Service).WithMany(sr => sr.ServiceRates).HasForeignKey(x => x.ServiceID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(r => r.User)
                    .WithMany(u => u.ServiceRates)
                     .HasForeignKey(s => s.UserID)
                      .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
