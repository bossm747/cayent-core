﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cayent.Core.Data.Components.Orders
{
    public class OrderDeliveryAddressBase
    {
        public string OrderId { get; set; }
        public virtual OrderBase Order { get; set; }

        public string RecipientName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string Address { get; set; }
        public double GeoX { get; set; }
        public double GeoY { get; set; }
    }

    public class OrderDeliveryAddressBaseConfiguration : EntityBaseConfiguration<OrderDeliveryAddressBase>
    {
        public override void Configure(EntityTypeBuilder<OrderDeliveryAddressBase> b)
        {
            b.ToTable("OrderDeliveryAddress");
            b.HasKey(e => e.OrderId);

            //b.WithOwner(e => e.Order);

            //b.Property(e => e.OrderAddressId).HasMaxLength(KeyMaxLength).IsRequired();
            b.Property(e => e.OrderId).HasMaxLength(KeyMaxLength).IsRequired();
            b.Property(e => e.RecipientName).HasMaxLength(NameMaxLength).IsRequired();
            b.Property(e => e.Email).HasMaxLength(DescMaxLength).IsRequired();
            b.Property(e => e.PhoneNumber).HasMaxLength(NameMaxLength).IsRequired();
            b.Property(e => e.Address).HasMaxLength(DescMaxLength).IsRequired();
        }
    }
}
