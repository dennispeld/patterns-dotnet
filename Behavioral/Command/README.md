# Command

**Command** is a design pattern, which encapsulates a request as an object, thereby allowing us developers to treat that request 
differently based upon what class receives said command.

## Example
I have created a Book class that sets a basic onformation of a book. After that, I have created an abstract class LibraryCommand and 3
classes implementing it (AddCommand, RemoveCommand, EditCommand). In addition, I created a BookReceiver that receives the upcoming command
and use it to perform it on the received book.
Finally, I created a class Library, that sets the commands, the books and calls the execute action.