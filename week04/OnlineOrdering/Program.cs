using System;
using System.Runtime.Intrinsics.Wasm;
public class Product{
  private string _name;
  private int _ID;
  private double _price;
  private int _quantity;
  public Product(string name, int id, double price, int quantity){
    _name = name;
    _ID = id;
    _price = price;
    _quantity = quantity;
  }
  public double Cost(){
    double total = _price * _quantity;
    return total;
  }
  public string GetName(){
    return _name;
  }
  public int GetID(){
    return _ID;
  }
}
public class Customer{
  private string _name;
  private Address _address;
  public Customer(string name){
    _name = name;
  }
  public void addAddress(string street,string city, string state, string country){
    Address address = new Address(street,city,state,country);
    _address = address;
  }
  public bool americanOrNot(){
    return _address.USAorNot();
  }
  public string GetName(){
    return _name;
  }
  public Address GetAddress(){
    return _address;
  }
}
public class Address{
  private string _street;
  private string _city;
  private string _stateProvince;
  private string _country;

  public Address(string street,string city, string state, string country){
    _street = street;
    _city = city;
    _stateProvince = state;
    _country = country;
  }
  public bool USAorNot(){
    return _country == "USA" ? true : false;
  }
  public string fullAddress(){
    return $"{_street} {_city} {_stateProvince} {_country}";
  }
}
public class Order{
    private Customer _customer;
    private List<Product> _products;
    public Order(Customer customer){
      _customer = customer;
      _products = new List<Product>();
    }
    public void addProduct(Product product){
      _products.Add(product);
    }
    public double totalCost(){
      double total = 0;
      int shippingCost = _customer.americanOrNot() ? 5 : 35;
      foreach (Product product in _products){
        total += product.Cost();
      }
      return total + shippingCost;
    }
    public void packingLabel(){
      List<string> label = new List<string>();
      foreach (Product product in _products){
        label.Add($"{product.GetName()} - ID: {product.GetID()}");
      }
      Console.WriteLine("Packing Label:");
      foreach (string line in label){
        Console.WriteLine(line);
      }
    }
    public void shippingLabel(){
      Console.WriteLine($"\nShipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().fullAddress()}");
    }
    public void Display(){
      double ftotal = totalCost();
      packingLabel();
      shippingLabel();
      Console.WriteLine($"Total Cost: ${ftotal}\n");
    }


}
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
