# Builder

**Builder** is a design pattern, in which you build up a complicated object with a single line.

## Example
A class Book has parameters that I want eventually initialize using a builder. I have created a class BookBuilder, that has two 
constructors, an empty one, that is public, and another one that takes a Book to initialize the protected member book.
After that, I initialize other 3 builders BookHistoryBuilder, BookInfoBuilder and BookLocationBuilder (all of them are inherited 
from BookBuilder) and retrieve the current book, that is being built. And finally, I implement an implicit opertator to retrieve 
the final value of a Book.