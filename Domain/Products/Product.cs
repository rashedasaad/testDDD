namespace Domain.Products;

public class Product
{
    public ProductId Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public Money Price { get; private set; }
    
    public Sku Sku { get; private set; }
    
}



public record Sku
{
    private const int DefaultLength = 15;
    public string Value { get; init; }
    private Sku(string value) => Value = value;

    public static Sku? Create(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return null;
        }

        if (value.Length != DefaultLength)
        {
            return null;
        }
        {
            
        }
        return new Sku(value);
    }
}