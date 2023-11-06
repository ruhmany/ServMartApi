using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Configuration
{
    public class RequestOfferConfiguratoin : IEntityTypeConfiguration<RequestOffer>
    {
        public void Configure(EntityTypeBuilder<RequestOffer> builder)
        {
            builder.ToTable("RequestOffer", "Service");
            builder.HasKey(i => i.ID);
            builder.Property(i => i.ID).ValueGeneratedOnAdd();
            builder.Property(s => s.State).IsRequired().HasMaxLength(15);
            builder.Property(i => i.StartDate).IsRequired();
            builder.Property(i => i.EndDate).IsRequired(); 
            builder.Property(i => i.Details).IsRequired().HasMaxLength(500);
            builder.Property(i => i.ExpectSalary).IsRequired();

            builder.HasOne(i => i.Request).WithMany(i => i.RequestOffer).HasForeignKey(i => i.RequestID).IsRequired();
            builder.HasOne(i => i.User).WithMany(p => p.RequestOffer).HasForeignKey(k => k.ProviderID);

        }
    }
}
