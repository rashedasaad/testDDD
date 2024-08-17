﻿using Domain.Customers;
using Domain.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configrations;

public class OrderConfiguration :IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(o => o.Id);
        
        builder.Property(o => o.Id).HasConversion(orderId => orderId.Value, id => new OrderId(id)); 
        
        builder.HasOne<Customer>().WithMany().HasForeignKey(o => o.CustomerId).IsRequired();
        builder.HasMany(o=> o.LineItems).WithOne().HasForeignKey(li => li.OrderId);
    
    }
    
}