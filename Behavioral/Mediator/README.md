# Mediator

**Mediator** is a design pattern, which defines an object which encapsulates how a set of objects interact with each other.

## Example
In this example, I am creating a BookPurchasedEventArgs class that implements a WarehouseEventArgs abstract class. Here I set a title and
amount of a purchased book and print an action. Next, I created a class OnlineBookstore, that is going to be used only to raise the event
each time a book is purchased. After that, I created a class Book, that stores the information about the book title, the amount in stock
and in which store it is sold. It also has a method Purchase() that posts the event to all subscribers. And, finally, the subscriber itself, 
a class Warehouse, so the people working there know the book is sold.
