using System;

class Program
{
    static void Main(string[] args)
    {
          // Create addresses
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("001 Oluseyi St", "Eleyele", "OYO", "Nigeria");

        // Create customers
        Customer customer1 = new Customer("Femi Akorede", address1);
        Customer customer2 = new Customer("Joseph Lawal", address2);

        // Create products
        Product product1 = new Product("Smart Watch", "SW123", 10.99f, 3);
        Product product2 = new Product("Gadget", "G456", 15.49f, 2);
        Product product3 = new Product("Tie", "T789", 7.25f, 5);

        // Create orders and add products to them
        Order order1 = new Order(customer1);
        order1.addProduct(product1);
        order1.addProduct(product2);

        Order order2 = new Order(customer2);
        order2.addProduct(product2);
        order2.addProduct(product3);

        // Add orders to a list
        List<Order> orders = new List<Order> { order1, order2 };

        // Display the information for each order
        foreach (Order order in orders)
        {
            Console.WriteLine("Order:");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.getPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.getShippingLabel());
            Console.WriteLine("Total Cost: $" + order.getTotalCost().ToString("F2"));
            Console.WriteLine();
        }
    }
}