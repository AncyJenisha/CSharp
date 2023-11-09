# ASSIGNMENT-15 IDISPOSABLE,DISPOSE PATTERN, FINALIZER IN C#
## Task-1 Managed and Unmanaged Resources
Managed Resources:

    Managed resources which are managed by CLR(Common Language Runtime) in .NET framework.

    Managed resources are objects like string, array, list or instances of the custom classes. 

    The objects when not in use, the garbage collector automatically frees up this memory.

Unmanaged Resources:

    Unmanaged Resources are not controlled by the .NET runtime's garbage collector.

    They are resources like file handles, network sockets, database collections that are provided by the operating system.

    The garbage collector is unable to clear them and needs to be released explicitly. 


## Task-2 Idisposable Interface

    The Idisposable interface uses a single method `Dispose()` to free up unmanaged resources. 

    It provides simple way to free up resources and manage memory efficiently.

## Task-3 Dispose Pattern
    
    Dispose pattern helps with the implementation of finalizers and Idsiposable interface provided by .NET

    The basic implementation of the pattern involves implementing the `IDisposable`` interface and declaring the `Dispose(bool)` method that implements all resource cleanup logic to be shared between the Dispose method and the optional finalizer.

## Task-4 Finalizer

    Finalizers perform necessary cleanups when class instance is being collected by the garbage collector.




## IdisposableImplementation


`ManagedResources.cs`

The `ManagedResources` class is designed to manage a list of string data. It implements the IDisposable interface to properly release resources when they are no longer needed.

1. `ListOfData` 

    Gets or sets a list of string elements.

    Access and manage a list of string data.  

2. `AddData(string data)`

   Adds a string to the list of data.

   `data` - The string to be added to the list.

3. `ClearData()`

   Clears the list of data.

4. `Dispose()`

    Implements the IDisposable interface to release resources.

    Properly disposes of the managed resources.


`UnmanagedResources.cs` 

The `UnmanagedResources` class is designed to manage an unmanaged resource (file) using IDisposable for proper resource cleanup.

1. `Resource` 

    Resources is a type of  SafeHandle class which provides critical finalization of handle resources, preventing handles from being reclaimed prematurely by garbage collection
 
2. `FileWriter` (Property)

    Represents a StreamWriter for writing to a file.

3. `WriteToFile(string content)` (Method)

    Writes content to the file.

    `content` - The content to be written to the file.

4. `CloseFile()` (Method)

    Closes the file.

5. `Dispose()` (Method)

    Implements the IDisposable interface to release resources.

    Properly disposes of the file and its resources
    
`Program.cs`

The `Program` class contains a Main method with examples of how to use the `ManagedResources` and `UnmanagedResources` classes.

`Main()`

1. Create an instance of `ManagedResources`, add data to it, and then dispose of it.

2. Create an instance of `UnmanagedResources` with a file path, write content to the file, and then dispose of it.