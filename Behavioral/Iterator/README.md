# Iterator

**Iterator** is a design pattern, which gets objects from a collection without exposing the collection itself. 

## Example
In this example, I created a simple class Book. Then I created a concrete iterator BookIterator that implements an interface IBookIterator
and a concrete aggregate Library that implements an interface ILibrary. So now, we can build a collection of books (our library), create
an iterator from it and get through each book using iterator.
