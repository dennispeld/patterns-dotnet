# Visitor

**Visitor** is a design pattern, which is used when we cannot modify existing classes, but need to change their behavior.

## Example
In this example, I want to implement such scenario: in a library we have a catalog with books, their basic information and availability.
Previously, the a reader could find the book by the genre and author (won't be implemented in this example). Now, I want to add an 
exact location of each book, so the readers would find it much faster.
I have created an abstract class BookElement and a class Book that inherits from it and accept the IVisitor interface. Meanwhile, 
I created a class LocationVisitor that implements IVisitor interface and changes the book's location. Finally, I created a class Library,
that adds books and sets each book to accept the visitor.