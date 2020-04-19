# Prototype

**Prototype** is a design pattern, in which you use a preconstructed model object that we can make copies of, customize and use them, instead
of creating everything frrom scratch (like Builder or Factory patterns).

## Example
First, I initialize a new book (class Book) by setting its Information and Location (both are separate classes). The Book class is implementing
an interface IDeepCopyable. To make a deep copy, I am using a copy constructors in all 3 classes.
After the book and a deep copy of it are created, I am changing the location of the copy and printing the information of both books and the copy.