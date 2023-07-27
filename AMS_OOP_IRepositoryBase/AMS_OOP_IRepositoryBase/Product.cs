using System;
using System.Collections.Generic;
public class Product : IRepositoryBase<Product> {
private List<Product> products = new List<Product>();
public void Add(Product entity) {
products.Add(entity);
Console.WriteLine($"Adding product {entity.Name} to database.");
}
public List<Product> GetAll() {
Console.WriteLine("Getting all products from database.");
return products;
}
public String Name { get; set; }
public void SendMail() {
Console.WriteLine("Cannot send email for products.");
}
}
