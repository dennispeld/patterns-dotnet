# State

**State** is a design pattern, which is changing an object's behaviour when its internal state changes.

## Example
In this example, I have created an abstract class ReadingProgress and 3 classes that inherit from it: Started, Halfway and Finished.
All they do, is passing the stated from one to another according to the state ("reading progress" in this example). Finally,
I created a class Book, that initializes the Started reading progress and has a method ReadPages() to update the progress.