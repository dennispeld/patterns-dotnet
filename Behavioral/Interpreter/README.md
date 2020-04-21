# Interpreter

**Interpreter** is a design pattern, which is used to defines a grammatical representation for a language and provides an interpreter to 
deal with this grammar.

## Example
In this simple example, an interface Expression is implemented in 3 classes TerminalExpression, OrExpression and AndExpression. 
I want to check if two given book titles are available in the library according to the condition we choose. With OrExpression, at least
one book should exist in the library. In AndCondition, both book titles should exist in the library.