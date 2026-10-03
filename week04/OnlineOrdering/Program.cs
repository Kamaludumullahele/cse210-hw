using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "San Francisco", "CA", "United States");
        Customer customer1 = new Customer("John Doe", address1.getAddress());
        Product product1 = new Product("Laptop", "P001", 999.99m, 1);
        Product product2 = new Product("Mouse", "P002", 49.99m, 2);

        // adding customer2
        Address address2 = new Address("456 Elm St", "Calgary", "Ab", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2.getAddress());
        Product product3 = new Product("Keyboard", "P003", 79.99m, 1);
        Product product4 = new Product("Monitor", "P004", 199.99m, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        List<Order> orders = new List<Order> { order1, order2 };
        DisplayOrders(orders);

        static void DisplayOrders(List<Order> orders)
        {
            foreach (Order order in orders)
            {
                Console.WriteLine("Total Price: " + order.GetTotalPrice());
                Console.WriteLine("Total Price with Shipping: " + order.GetTotalPriceWithShipping());
                Console.WriteLine("Shipping Label: " + order.GetShippingLabel());
                Console.WriteLine("Packing Label: " + order.GetPackingLabel());
                Console.WriteLine("--------------------------------------------------");
            }
        }
    }
}