using CsBases.Fundamentals;

public class ProductAdapter
{
    public static ProductDTO ToDto(Product product) {
        return new ProductDTO
        {
            Name = product.Name ?? "Sin Nombre",
            Price = product.Price,
            Code = $"P-{product.Id}-{product.UniqueCode.ToString().Substring(0,8)}",
        };
    }
}