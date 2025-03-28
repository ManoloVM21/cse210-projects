using System;
using System.Runtime.Intrinsics.Wasm;
class Program
{
    static void Main(string[] args)
    {
      Customer customer1 = new Customer("Jason Momoa");
      customer1.addAddress("1234 Elm Street","Los Angeles","CA","USA");
      Order order1 = new Order(customer1);
      Product product1 = new Product("Laptop",101,999.99,2);
      Product product2 = new Product("Mouse",102,25.50,5);
      Product product3 = new Product("Keyboard",103,49.99,3);
      order1.addProduct(product1);
      order1.addProduct(product2);
      order1.addProduct(product3);
      Console.WriteLine("\nFOR ORDER_1:\n");
      order1.Display();

      Customer customer2 = new Customer("Justin Bieber");
      customer2.addAddress("5678 Maple Avenue","Toronto","ON","CA");
      Order order2 = new Order(customer2);
      Product product4 = new Product("TV",104,199.99,1);
      Product product5 = new Product("Freezer",105,79.9,4);
      order2.addProduct(product4);
      order2.addProduct(product5);
      Console.WriteLine("\nFOR ORDER_2:\n");
      order2.Display();
  }
}
