# ASSIGNMENT-10 ERROR HANDLING IN CSHARP
## Task-1 Try,Catch,Finaly blocks
Try-Catch-Finally

The try-catch-finally block is used to handle exceptions that might occur while executing the program, and finally block is to have the task to executed after control leaves the try catch block. 

Try Block:
    
    The Try block has the code, that is likely to have an exception.

Catch Block:
    
    The catch block catches the exception, with the type of exception specified.
        
    A number of catch blocks of different exception can be chained together.
        
    The catch blocks are execyted in top to bottom order.
        
    Only one catch block with more suitable exception or base exception is executed.

Finally Block:
    
    The finally block is executed after the control leaves the try catch block.
        
    It is executed, independent of the exception being caught.

Program Class:

    The program class has the main method,it reads two inputs from user to divide.

    try:
    The try block calls the divide method, which divides the number1 by number2 entered by the user.

    catch:
    The catch block catches the exception and displays the typeof exception.

    finally:
    It displays the message after the try-catch block.
    
InputReaders Class:

    The InputReaders has the methods to read string input from user and convert it into integer.

Operators Class:

    The Operators class has the divide method to divide the divident by divisor.

![Divide By ZeroException](.\Images\10.1.DivideByZeroException.png)

## Task-2 Catching And Throwing Different Types of Exception
Program Class:

    The Program class has the main method.
  
    It reads the array elements to be stored in the array.
    
    It reads the index from the user to be displayed.

    try:
    The try block displays the element of the array by the index recieved from user.

    catch:
    The catch block catches the IndexOutOfRangeException and displays the type of error.
    
![Index Out of Range Exception](.\Images\10.2.IndexOutOfRangeExcepton.png)

## Task-3 Defining and Using custom Exception Class
    A class InvalidInputException is created, which inherits the Exception class.

    Custom exception class name should end with 'exception'.

    The default constructors are added.

    A localised message to be displayed is added in the try block, within the throw statement.

Program Class:

    The index to be displayed recieved from user is parsed within the try block, to check if the string recieved is an integer.

    If the string cannot be converted to an integer, it throws an InvalidInputException.

    The message "Enter a valid number" is displayed, when the exception is thrown.

![Invalid Input Exception](.\Images\10.3.InvalidInputException.png)

## Task-4 Handling Global Unhandled Exception
A method to add elements to an array is created.
    
The method is unhandled for the type of input read.
    
When an exception occurs, .NET runtime looks for an handler that can handle the exception.
    
When there is no handler for the exception, the program is terminated.
    
To provide an global exception handler subscribe to Appdomain.UnhandledException.
    
The event is raised, whenever an unhandled exception occurs.
    
If an exception occurs and no handler is available to catch it, the HandleException method is executed to display the message.

![Handling Global Unhandled Exception](.\Images\10.4.UnhandledGlobalExceptionHandled.png)

## Task-5 Using and Global Exception Handler Console Application
A trace of method calls is stacktrace.

The stack trace listing provides a way to follow the call stack to the line number, where the exception occurs.

The Stacktrace shows the exception that occurred at line 55, the index out of range error.

![Stacktrace showing the IndexOutOfRangeException](.\Images\10.5.1.StackTrace.png)

The Stacktrace shows the exception at line 24, due to Array Type mismatch exception.

Then the stack shows the line 36, where the method with the exception is called.

![Stacktrace showing the ArrayTypeMismatchException](.\Images\10.5.2.StackTrace.png)