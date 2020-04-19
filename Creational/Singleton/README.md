# Singleton

**Singleton** is a design pattern, in which you only create an instance of an object once and not more.

## Example
The approach is simple. We need to set a constructor of our class Library private and introduce a lazy loading object, that 
will be initialized only once, when the object is created and then it will be just retrieving it in each new call.