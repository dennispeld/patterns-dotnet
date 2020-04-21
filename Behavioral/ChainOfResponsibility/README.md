# Chain of Responsibility

**Chain of Responsibility** is a design pattern, in which we pass an object along a chain of potential handlers for that object until one of
the handlers process the request.

## Example
In this example, I have an Order class that represents an order in an online book store. Then, I created an abstract class Packer, a person
that will handle the order and pack the ordered books before the package will be sent to a customer. I created a hierarchy of the packers,
JuniorPacker, MidlevelPacker and SeniorPacker. All of them inherit from Packer class and implement Handle() method. According to how many 
orders each packer can handle, it goes processed from lower to higher level in hierarchy.