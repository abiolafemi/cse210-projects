public class Product
{
    private string _name;
    private string _id;
    private float _price;
    private int _quantity;

    public Product(string name, string id, float price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string getName()
    {
        return _name;
    }

    public string getId()
    {
        return _id;
    }

    public float getPrice()
    {
        return _price;
    }

    public int getQuantity()
    {
        return _quantity;
    }

    public float getTotalCost()
    {
        return _price * _quantity;
    }
}
