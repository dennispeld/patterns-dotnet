# Memento

**Memento** is a design pattern, which tries to save object's state so that the object can be restored to this state at a later time.
The purpose of this pattern is to separate the current state of the object from a previous state.

## Example
In this example, I have created a Publisher class that has Save (to save the current state in memento) and Restore (to get the previous 
state from memento). Then, I created memento itself, a PublisherMemento class. And finally, I created a ContactBook that has the memento 
as its one and only property. 