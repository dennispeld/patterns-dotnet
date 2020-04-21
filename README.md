# patterns-dotnet

**patterns-dotnet** is a simple .NET Core 3.1 console application to demonstrate some of the design patterns using C# language.

## Creational Patterns
- [Builder](Creational/Builder) (**Used for:** creating objects with many steps, where each step has a different implementation)
- **[Factory](Creational/Factory)** (**Used for:** creating related objects without specifying the exact class of the object) - **very userful**
- [Prototype](Creational/Prototype) (**Used for:** creating many similar objects) - **somehow useful**
- [Singleton](Creational/Singleton) (**Used for:** creating only one and only object)

## Structural Patterns
- **[Adapter](Structural/Adapter)** (**Used for:** adapting an old interface that canot be changed into new life) - **very useful**
- [Bridge](Structural/Bridge) (**Used for:** allowing many variations between implementations of abstractions) - **somehow useful**
- **[Composite](Structural/Composite)** (**Used for:** treating the same way different objects in a hierarchy) - **very useful**
- [Decorator](Structural/Decorator) (**Used for:** injecting new functionality into instances of objects at runtime rather than including that functionality in the class of objects) - **somehow useful**
- **[Facade](Structural/Facade)** (**Used for:** hiding complex implementations) - **very useful**
- [Flyweight](Structural/Flyweight) (**Used for:** creating lots of instances of the same set of objects and with that improving performance)
- **[Proxy](Structural/Proxy)** (**Used for:** controlling access to a particular object) - **very useful**

## Behavioral Patterns
- [Chain of Responsibility](Behavioral/ChainOfResponsibility) (**Used for:** allowing multiple different objects to possibly process a request)
- **[Command](Behavioral/Command)** (**Used for:** encapsulating requests as objects so that they can be handled differently by different receivers) - **very useful**
- [Interpreter](Behavioral/Interpreter) (**Used for:** interpreting an input)
- **[Iterator](Behavioral/Iterator)** (**Used for:** extracting objects from a collection without exposing the collection itself) - **very useful**
- [Mediator](Behavioral/Mediator) (**Used for:** defining how objects interact with each other)
- [Memento](Behavioral/Memento) (**Used for:** restoring an object's state from a previous state)
- Null Object
- Observer
- State
- Strategy
- Template Method
- Visitor
