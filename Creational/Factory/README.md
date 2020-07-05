# Factory

**Factory** is a design pattern, in which you use factory methods to deal with the problem of creating objects without having 
to specify the exact class of the object that will be created.

## Example
I have created two classes Book and Magazine, that implement IReadable interface. In another class, ReadableFactory, I am creating a
class by the ReadableType, so we can utilize it only by specifying the type we need.
