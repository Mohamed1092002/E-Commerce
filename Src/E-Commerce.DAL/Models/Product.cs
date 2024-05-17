namespace E_Commerce.DAL.Models;

public class Product
{
    public Product(int id, string name, string description, decimal price)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}