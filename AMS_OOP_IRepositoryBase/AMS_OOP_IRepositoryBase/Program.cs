using System;
class Program {
static void Main(string[] args) {
Customer customer1 = new Customer();
customer1.Name = "Cellbo";
Customer customer2 = new Customer();
customer2.Name = "Felpo";
customer1.Add(customer1);
customer2.Add(customer2);
Console.WriteLine("List of customers:");
foreach (Customer customer in customer1.GetAll()) {
Console.WriteLine($"- {customer.Name}");
}
customer1.SendMail();
Product product1 = new Product();
product1.Name = "Sabonete";
Product product2 = new Product();
product2.Name = "Motoserra";
product1.Add(product1);
product2.Add(product2);
Console.WriteLine("List of products:");
foreach (Product product in product1.GetAll()) {
Console.WriteLine($"- {product.Name}");
}
}
}