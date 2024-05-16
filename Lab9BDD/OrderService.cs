namespace Lab8BDD;

public class OrderService
{
    public Order CreateOrder(Customer customer)
    {
        return new Order(customer);
    }

    public void AddProductToOrder(Order order, Product product)
    {
        order.AddProduct(product);
    }
}