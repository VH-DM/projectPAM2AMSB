using System;
using System.Collections.Generic;
public class Customer : IRepositoryBase<Customer> {
private List<Customer> customers = new List<Customer>();
public void Add(Customer entity) {
customers.Add(entity);
Console.WriteLine($"Adding customer {entity.Name} to database.");
}
public List<Customer> GetAll() {
Console.WriteLine("Getting all customers from database.");
return customers;
}
public String Name { get; set; }
public void SendMail() {
Console.WriteLine("Sending an email to customers.");
}
}
