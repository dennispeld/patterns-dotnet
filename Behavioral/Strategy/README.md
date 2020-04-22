# Strategy

**Strategy** is a design pattern, which defines a family of algorithms, then makes them interchangeable by encapsulating each as an object.

## Example
At first, I created a SortStrategy abstract class and 3 classes that inherit and implement it: Library, Bookstore and DecorLibrary.
In each of these classes I am using LINQ to sort the list of books: in Library by genre, in Bookstore by author and in DecorLibrary by cover
color. Finally, so tie everything together, I created a class SortingMethod, that references to both list of books and SortStrategy.