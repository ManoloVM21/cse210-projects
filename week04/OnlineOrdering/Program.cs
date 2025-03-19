using System;
class Product{
            public string _name;
            public double _price;

            public Product(string name, double price){
                _name = name;
                _price = price;
            }
        }
class Program
{
    static void Main(string[] args)
    {
      List<Product> products = new List<Product> {
        new Product("Car", 2000.00),
        new Product("Mouse",20),
        new Product("Teclado",40),
        new Product("Audifonos", 120),
        new Product("Monitor",230)
      };  
      List<Product> filteredproducts = products.Where(product => product._price >50).ToList();
      Console.WriteLine(string.Join(", ",filteredproducts));
  }
}
