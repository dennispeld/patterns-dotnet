# Proxy

**Proxy** is a design pattern, which provides a placeholder object to control access to another object. The Proxy can hide or change 
the data or manipulate its behaviour.

## Example
In this example, I created IBookReader interface and the EBookReader class that implements this interface. Now, I want to manipulate with
its behaviour by creating a proxy EBookReaderProxy, that hypotetically I am going to use for a more modern eBook reader.
In the proxy, I added a check of the eBook file format and if it is outdated, a suggestion to convert to a new format is shown.
To load the book it calls the Load() method from the initialal EBookReader, to which it has a reference.