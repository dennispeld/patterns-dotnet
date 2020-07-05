# Decorator

**Decorator** is a design pattern, in which we are adding new functionality to an existing object without changing that object's definition
(similar to Open-Closed princple).

## Example
Let's say, we have a an online store that sells paper books. A new initiative is to digitalize them and sell eBooks, which would help the
store owner to sell book even if the paper one are all sold out.
First, I have PaperBook abstract class and Book class that implements PaperBook. 
Now, I created a Decorator abstract class that inherits from PaperBook as well and initializes it from within.
Finally, the concrete implementation of that Decorator is happening in the EBook class.
