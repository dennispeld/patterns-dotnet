# Bridge

**Bridge** is a design pattern, ehich is used to separate abstraction from its implementation so that both can be modified independently.

## Example
Let's say, we want to order books online or in the walk-in bookstore. The idea is to implement such order system, that would allow us to 
put an order without knowing type of order delivery (next day delivery order or self pick-up order) and not knowing where the order is taking
place (online or a bookstore). Instead of creating classes for each scenario (next day delivery at bookstore, next day delivery at online 
store etc), we can implement a bridge template.

First, we create an Implementator, which in our case will be IOrderingSystem interface.
Second, we need an Abstraction, which in our case will be an abstract class DeliverOrder, that will have a reference to our Implementator.
After that, we can define RefinedAbstraction classes, which in our case will be the classes for different type of delivery, one for 
next day delivery (NextDayDeliveryOrder) and one for self pick up (SelfPickupOrder).
Finally, we need to define the ConcreteImplementaror (our shops, either Bookstore or OnlineStore).
Now we can place an order of any delivery type to any store.