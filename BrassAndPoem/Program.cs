using System;

List<Product> products = new List<Product>
{
    new Product() { Name = "The Sun and Her Flowers", Price = 14.99m, ProductTypeId = 100 },
    new Product() { Name = "Golden Melody Acoustic Guitar", Price = 249.99m, ProductTypeId = 200 },
    new Product() { Name = "Leaves of Grass", Price = 10.75m, ProductTypeId = 101 },
    new Product() { Name = "SilverTone Alto Saxophone", Price = 599.50m, ProductTypeId = 201 },
    new Product() { Name = "Devotions: The Selected Poems of Mary Oliver", Price = 18.50m, ProductTypeId = 102 },
    new Product() { Name = "HarmonyKeys Digital Piano", Price = 429.00m, ProductTypeId = 202 }
};

List<ProductType> producttype = new List<ProductType>
{
    new ProductType() { Title = "Book", Id = 1 },
    new ProductType() { Title = "Musical Instrument", Id = 2 }
};

string greeting = @"Welcome to BrassAndPoem -
The place online to find a eclectic mixture of music and poetry!";

string choice = null;
while (choice != "0")
{
    Console.WriteLine(greeting);
    Console.WriteLine(@"Choose an option:
                            1. Display all products
                            2. Delete a product
                            3. Add a new product
                            4. Update product properties
                            5. Exit");
    choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            // method
            break;

        case "2":
            // method
            break;

        case "3":
            // method
            break;

        case "4":
            // method
            break;

        case "5":
            Console.WriteLine("Goodbye!");
            break;
    }
}
return;





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
