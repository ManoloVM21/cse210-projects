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