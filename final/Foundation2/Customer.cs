public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string getName()
    {
        return _name;
    }

    public Address getAddress()
    {
        return _address;
    }

    public bool isInUSA()
    {
        return _address.isInUSA();
    }
}
