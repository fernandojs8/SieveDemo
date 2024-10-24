using SieveDemo.Models;

namespace SieveDemo.DBContext
{
    public class ProductDB
    {
        public List<ProductModel> ProductDataContext { get; } = new List<ProductModel>()
        {
            new ProductModel { Id = 1, Name = "Mouse", Description = "Wireless Mouse", Price = 300 },
            new ProductModel { Id = 2, Name = "Keyboard", Description = "Mechanical Keyboard", Price = 340 },
            new ProductModel { Id = 3, Name = "Speaker", Description = "Bluetooth Speaker", Price = 200 },
            new ProductModel { Id = 4, Name = "CPU", Description = "High Performance CPU", Price = 3400 },
            new ProductModel { Id = 5, Name = "Headphone", Description = "Noise Cancelling Headphones", Price = 110 },
            new ProductModel { Id = 6, Name = "Desktop", Description = "All-in-one Desktop", Price = 1000 },
            new ProductModel { Id = 7, Name = "Desk Lamp", Description = "LED Desk Lamp", Price = 100 },
            new ProductModel { Id = 8, Name = "Table Fan", Description = "Portable Table Fan", Price = 130 },
            new ProductModel { Id = 9, Name = "File Box", Description = "Office File Storage Box", Price = 40 },
            new ProductModel { Id = 10, Name = "Key Holder", Description = "Wall-mounted Key Holder", Price = 10 },
        };
    }
}
