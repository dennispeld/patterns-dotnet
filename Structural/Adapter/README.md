# Adapter

**Adapter** is a design pattern, in which you adapt an interface you have to the interface you need. This pattern involves a single class 
called adapter which is responsible for communication between two independent or incompatible interfaces.

## Example
In this example, I have an old legacy code that retrieves a list of paper books. Let's assume, a library wants to have a collection of
favourite quotes from any book.
IBook interface is Adaptee. Book class implements IBook interface.
IQuote interface is Target interface. Quote implements IQuote interface.
BookAdapter is the adapter that builds sort of bond between Book and Quote and retrieves the parts of selected text in a book as saves it as 
a quote.
