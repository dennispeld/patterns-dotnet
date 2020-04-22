# Observer

**Observer** is a design pattern, which is used when you want one component to notify another component that something has happened.

## Example
In this example, we want to notify all the readers who wants to read a specific book, that this book is available in the library.
I have created a class AvailabilityChangedEventArgs that will be used as arguments for our event call to pass the book and it's availability.
Then, I created a Book class, that declares the event handler in case if a book's availability has changed and a method SetAvailability() that
invokes this event.
Finally, I have created a class Reader, that could take books into their watchlist (and that would automatically subscribe them to the
availability change event) and displays all the availability changes he has been receiving.