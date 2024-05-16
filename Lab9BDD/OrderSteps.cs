using TechTalk.SpecFlow;

namespace Lab8BDD;

[Binding]
public class OrderSteps
{
    private Customer _customer;
    private Order _order;
    private readonly OrderService _orderService;

    public OrderSteps()
    {
        _orderService = new OrderService();
    }

    [Given(@"I am a customer named ""(.*)""")]
    public void GivenIAmACustomerNamed(string name)
    {
        _customer = new Customer(name);
    }

    [Given(@"I have a customer named ""(.*)""")]
    public void GivenIHaveACustomerNamed(string name)
    {
        _customer = new Customer(name);
    }

    [When(@"I create a new order")]
    public void WhenICreateANewOrder()
    {
        _order = _orderService.CreateOrder(_customer);
    }

    [Then(@"the order should be created for ""(.*)""")]
    public void ThenTheOrderShouldBeCreatedFor(string name)
    {
        Assert.AreEqual(name, _order.Customer.Name);
    }

    [Given(@"I have created a new order for ""(.*)""")]
    public void GivenIHaveCreatedANewOrderFor(string name)
    {
        _customer = new Customer(name);
        _order = _orderService.CreateOrder(_customer);
    }

    [When(@"I add a product named ""(.*)"" with price (.*) to the order")]
    public void WhenIAddAProductNamedWithPriceToTheOrder(string productName, decimal price)
    {
        var product = new Product(productName, price);
        _orderService.AddProductToOrder(_order, product);
    }

    [Then(@"the total amount of the order should be (.*)")]
    public void ThenTheTotalAmountOfTheOrderShouldBe(decimal expectedTotal)
    {
        Assert.AreEqual(expectedTotal, _order.TotalAmount);
    }


}