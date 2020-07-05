# Flyweight

**Flyweight** is a design pattern, in which you allow many instances of an object to share their state and improve the performance.

## Example
For example, we have an OrderItem abstract class, something that we will be selling in our online store.
Now, let's create two ConcreteFlyweight objects Book and EBook classes, that will inherit from the OrderItem. They look identical.
Finally, we create a FlyweightFactory object and name it OrderItemFactory, which will store already created order items and any time 
another item of the same type must be created, the factory will use the existing one rather that creating a new one.
