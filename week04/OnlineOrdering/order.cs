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