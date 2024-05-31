using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void addProduct(Product product)
    {
        _products.Add(product);
    }

    public List<Product> getProducts()
    {
        return _products;
    }

    public Customer getCustomer()
    {
        return _customer;
    }

    public float getShippingCost()
    {
        return _customer.isInUSA() ? 5.0f : 35.0f;
    }

    public float getTotalCost()
    {
        float total = getShippingCost();
        foreach (var product in _products)
        {
            total += product.getTotalCost();
        }
        return total;
    }

    public string getPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        foreach (var product in _products)
        {
            packingLabel.AppendLine($"{product.getName()} ({product.getId()})");
        }
        return packingLabel.ToString();
    }

    public string getShippingLabel()
    {
        return $"{_customer.getName()}\n{_customer.getAddress().getFullAddress()}";
    }
}
