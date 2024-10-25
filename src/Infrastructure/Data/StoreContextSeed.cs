using System;
using System.Text.Json;
using System.Text.Json.Nodes;
using Core.Entities;

namespace Infrastructure.Data;

public class StoreContextSeed
{
    public static async Task SeedAsync(StoreContext context){
        if(!context.Products.Any()){
            var productsData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/Products.json");
            var products = JsonSerializer.Deserialize<List<Product>>(productsData);
            if (products==null) return;
            context.Products.AddRange(products);
            await context.SaveChangesAsync();
        }
    }

}
