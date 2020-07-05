# Facade

**Facade** is a design pattern, in which we create a layer with a simple structure over the more complex structure.

## Example
First, I created a class OrderItem, which I will use as parent for every item I can sell in the online store, and an interface
IOrderable, that has a method Order() to be implemented.
Now, I create couple of classes for different types of items, EBook and Book, both implementing IOrderable interface. And finally,
the facade itself, class OnlineStore, is hiding everything from the complex system and only shows only the summery of the order.
