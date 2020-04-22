# Null Object

**Null Object** is a design pattern, which is used when you don't want a piece of functionality, which is built into an interface.

## Example
In this example, I created an interface IReview that is implemented by Review and NullReview classes. NullReview class is the empty sealed 
class that has no implementation. Finally, I created a class Book that has a reference to IReview interface. Now, when we create a book, we 
can specify if the book could have reviews or not. If not, it will use the NullReview class, so any added review will be ignored.