# Template Method

**Template Method** is a design pattern, which is used for reating an outline of an algorithm but letting specific steps be implemented 
by other classes.

## Example
The example is quite simple. I created a Publishing abstract class that sets up steps for publishing a book. I have inherited this class
by 3 classes: FirstEdition, SecondEdition and ThirdEdition. All of them have implemented the necessary steps.