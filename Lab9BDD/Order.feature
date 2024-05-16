Feature: Order Management
As a customer
I want to create an order and add products to it
So that I can purchase items I want

Scenario: Create a new order
Given I am a customer named "Janusz Kowalski"
When I create a new order
Then the order should be created for "Janusz Kowalski"

Scenario: Add products to the order
Given I have a customer named "Janusz Kowalski"
And I have created a new order for "Janusz Kowalski"
When I add a product named "Laptop" with price 1000.00 to the order
And I add a product named "Mouse" with price 50.00 to the order
Then the total amount of the order should be 1050.00


Scenario: Add multiple products to the order
Given I have a customer named "Janusz Kowalski"
And I have created a new order for "Janusz Kowalski"
When I add a product named "Keyboard" with price 150.00 to the order
And I add a product named "Monitor" with price 300.00 to the order
And I add a product named "HDMI Cable" with price 20.00 to the order
Then the total amount of the order should be 470.00


Scenario: Check order with no products
Given I have a customer named "Jan Nowak"
And I have created a new order for "Jan Nowak"
Then the total amount of the order should be 0.00


Scenario: Add same product twice
Given I have a customer named "Karol Kula"
And I have created a new order for "Karol Kula"
When I add a product named "USB Drive" with price 25.00 to the order
And I add a product named "USB Drive" with price 25.00 to the order
Then the total amount of the order should be 50.00