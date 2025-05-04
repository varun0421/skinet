using System;
using System.Text.Json;

namespace Infrastructure.Data;

public class StoreContextSeed
{
    public static async Task SeedAsync(StoreContext context)
    {
        if (!context.Products.Any())
        {
            var productsData= await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/Products.json");
            var products = JsonSerializer.Deserialize<List<Core.Entities.Product>>(productsData);

            if(products== null) return;

            context.Products.AddRange(products);
            await context.SaveChangesAsync();
        }
    }
}
    
