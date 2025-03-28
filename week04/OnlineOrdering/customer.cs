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