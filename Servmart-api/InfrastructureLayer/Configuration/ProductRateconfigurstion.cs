using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureLayer.Configuration
{
    public class ProductRateconfigurstion : IEntityTypeConfiguration<ProductRate>
    {
        public void Configure(EntityTypeBuilder<ProductRate> builder)
        {
            builder.ToTable("ProductRate", "Product");
            builder.HasKey(x => x.ID);
            builder.Property(r => r.Description).HasMaxLength(250).IsRequired();
            builder.Property(r => r.Rate).IsRequired();
            builder.HasOne(P => P.Product).WithMany(Pr => Pr.ProductRates).HasForeignKey(x => x.ProductId);
            builder.HasOne(r => r.User)
                .WithMany(u => u.ProductRates)
                 .HasForeignKey(s => s.CustomerID)
                  .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
