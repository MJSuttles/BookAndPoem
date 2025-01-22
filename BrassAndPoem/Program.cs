using System;

List<Product> products = new List<Product>
{
    new Product() { Name = "Whispers of the Eternal Sky", Price = 15.99m, ProductTypeId = 100 },
    new Product() { Name = "Golden Melody Acoustic Guitar", Price = 249.99m, ProductTypeId = 200 },
    new Product() { Name = "The Enchanted Forest Chronicles", Price = 12.49m, ProductTypeId = 101 },
    new Product() { Name = "SilverTone Alto Saxophone", Price = 599.50m, ProductTypeId = 201 },
    new Product() { Name = "Beyond the Horizon: A Journey Untold", Price = 18.75m, ProductTypeId = 102 },
    new Product() { Name = "HarmonyKeys Digital Piano", Price = 429.00m, ProductTypeId = 202 }
};

List<ProductType> producttype = new List<ProductType>
{
    new ProductType() { Title = "Book", Id = 1 },
    new ProductType() { Title = "Musical Instrument", Id = 2 }
};

void DisplayMenu()
{
    throw new NotImplementedException();
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }