﻿using CsBases.Fundamentals;
using CsBases.Fundamentals._07_Metodos_asincronos;

class Program
{
    static async Task Main()
    {
        var laptop = new Product("Laptop", 1200);
        WriteLine(laptop.GetDescription());
        var soporte = new ServiceProduct("Soporte tecnico", 300, 30);
        // WriteLine(soporte.GetDescription());

        var product = new Product("Mouse Gamer", 300);
        var ProductDTO = ProductAdapter.ToDto(product);
        // WriteLine($"{ProductDTO.Name} - {ProductDTO.Price} - Codigo: {ProductDTO.Code}");

        // Inyeccion de dependencias
        ILabelService labelService = new LabelService();
        var manager = new ProductManager(labelService);
        var monitor = new Product("Monitor", 100);
        var installation = new ServiceProduct("Instalacion de monitor", 20, 30);

        // manager.PrintLabel(monitor);
        // manager.PrintLabel(installation);

        var firstProduct = await new ProductRepository().GetProduct(1);
        firstProduct.Description = "Esta es la descripcion del primer producto";
        AttributeProcessor.ApplyUpperCase(firstProduct);
        WriteLine($"{firstProduct.Name} - {firstProduct.Price} - {firstProduct.Description}");
    }
}
