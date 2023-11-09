# ASSIGNMENT 16 LOGGING SYSTEM USING SINGLETON AND FACTORY PATTERN

`Program.cs`: 
    
    Contains the Main method, which demonstrates how to use the logging system by logging messages in either plain text or JSON format.

`ILogger interface`:

     Defines the contract for logging messages. It provides two implementations of this interface: JsonLogger and TextLogger.

    `createLogger()`:
      Gets a string describing the type of logger and returns An object that implements the ILogger interface, either a JsonLogger or a TextLogger.

`SimpleLoggerFactory`: 
    
    Creates instances of the logger based on the specified type (either "Json" or "SimpleText").

`LoggerFactory`:

     An abstract factory that defines a method for creating logger instances.

`LoggingSystem` : 

    A thread-safe singleton class that manages the creation and retrieval of logger instances. It includes a LogMethod to log messages using the appropriate logger based on the specified type.