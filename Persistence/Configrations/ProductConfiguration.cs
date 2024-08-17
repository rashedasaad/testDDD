using Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configrations;

internal class ProductConfiguration: IEntityTypeConfiguration<Product>
{
  
    public void Configure(EntityTypeBuilder<Product> builder)
    {
       builder.HasKey(x => x.Id);
       builder.Property(x => x.Id).HasConversion(productId => productId.Value, id => new ProductId(id));
       builder.Property(x => x.Sku).HasConversion(sku =>  sku.Value , value =>Sku.Create(value)!);
    builder.OwnsOne(p => p.Price, price =>
    {
        price.Property(p => p.Currency).HasMaxLength(3);
        
    });

    }
}