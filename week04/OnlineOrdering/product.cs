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