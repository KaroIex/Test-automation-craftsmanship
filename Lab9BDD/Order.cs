namespace Lab8BDD;

public class Order(Customer customer)
{
    public Customer Customer { get; private set; } = customer;
    public List<Product> Products { get; private set; } = new();
    public decimal TotalAmount { get; private set; } = 0;

    public void AddProduct(Product product)
    {
        Products.Add(product);
        TotalAmount += product.Price;
    }
}