using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Configuration
{
    public class OrderConfigurations : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.ID);
            builder.Property(o => o.ID).ValueGeneratedOnAdd();
            builder.HasOne(o => o.User).WithMany(u => u.Orders).HasForeignKey(o => o.UserID);
        }
    }
}
