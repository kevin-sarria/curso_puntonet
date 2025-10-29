namespace CsBases.Fundamentals._07_Metodos_asincronos;

public class ProductRepository
{
    public async Task<Product> GetProduct(int id)
    {
        // Obtener de una base de datos,
        // una llamada a un API externa
        // o prodria ser de un archivo
        WriteLine("Buscando producto...");
        await Task.Delay(2000);
        return new Product("Producto simulado", 500);
    }
}
