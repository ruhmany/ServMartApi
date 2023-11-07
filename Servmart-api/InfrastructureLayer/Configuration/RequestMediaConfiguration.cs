﻿using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureLayer.Configuration
{
	public class RequestMediaConfiguration : IEntityTypeConfiguration<RequestMedia>
	{
		public void Configure( EntityTypeBuilder<RequestMedia> builder )
		{
			builder.ToTable( "RequestMedia", "Service" );
			builder.HasKey( i => i.ID );
			builder.Property( i => i.ID ).ValueGeneratedOnAdd();
			builder.Property( m => m.MediaUrl ).IsRequired().HasMaxLength( 500 );
			builder.HasOne( i => i.RequestImages ).WithMany( i => i.ImagesMedia ).HasForeignKey( i => i.RequestID ).OnDelete(DeleteBehavior.NoAction).IsRequired();
			builder.HasOne( i => i.RequestVideo ).WithOne( i => i.VideoMedia ).HasForeignKey<RequestMedia>( i => i.RequestID ).OnDelete( DeleteBehavior.NoAction ).IsRequired();
		}
	}
}
