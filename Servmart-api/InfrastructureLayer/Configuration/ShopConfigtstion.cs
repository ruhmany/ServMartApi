using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureLayer.Configuration
{
    public class ShopConfigtstion : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.ToTable("Shop", "Shop");
            builder.HasKey(s => s.ID);
            builder.Property(s => s.Name).HasMaxLength(50).IsRequired();
            builder.Property(s => s.Address).HasMaxLength(250).IsRequired();
            builder.HasOne(s => s.Owner).WithOne(i => i.Shop).HasForeignKey<Shop>(i => i.UserID);

        }

    }
}
