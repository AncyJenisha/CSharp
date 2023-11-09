# ASSIGNMENT-14 
## Task-1 Implementation Of Async/Await
Program.cs:
    
    Main():

        Calls the `DownloadFileFromUrl()` method passing a URL as string for input parameter.

        Gets the value from the `DownloadFileFromUrl()` and displays it.

        Calls the `DownloadFileFromUrl()`  method passing another URL as string .

        Gets the value from the method and displays it.

UrlContentDownload.cs:

    DowloadFileFromUrl():

        Gets the URL as string.

        An object, `client` for HTTPClient is created.

        GetStringAsync() is called passing the the url as input parameter, it is awaited and the contents is stored in `contentFromUrl` as string.

        The value from the method is retured as string.

## Task-2 Implementing Task Parallel Library.
Program.cs:

    Main():
        Instantiates a new array `arrayOfNumbers` and values are assigned to it from 1 to 10000.

        `Parallel.For` loop is used to run the values parallely and square it and print the values.

Inference:
    
    The timespan for the parallel for loop is comparetively less than the sequential for loop.
    

## Task-3 Usage Of Multithreading:

Program.cs:

    Main():

        The task of creating an array runs in the `firstThread`

        The method `SquareArrayElements` runs in another thread `secondThread` after the `firstThread` joins it.

        The `DisplayArrayElements` run in `thirdThread` and and the `secondThread` and the `thirdThread` starts running.

MathOperators.cs:

    CreateArray():

        Creates an array of size 10 and assigns value from 1 to 10 to it.

    SquareArrayElements():

         Gets the arrayOfNumbers as input Squares the array elements and stores it in the `arrayOfSquaredNumbers` and returns it.

    DisplayArrayElemets():

        Gets the arrayOfNumbers and and displays it.


## Task-4 Multi-Layered Async Await.
Program.cs

    Main():
        The `JsonCounterOfContensOfUrl` from `CpuBoundOperations` class is called and awaited to display.

CpuBoundOperations.cs

    UrlGenerator():

        The method gets a list of url as string.

        Returns the list of url.

    DownloadFileFromUrl():

        Awaits the `DownloadFileFromUrl()` and gets the result and stores it in `url` as string.

        An object `client` for `HttpClient` is created and the `GetStringAsync()` is called with the url as input parameter.

        The contents form the url is returned as string.

    JsonCounterOfContentsOfUrl():

        Calls the `DownloadFileFromUrl()` and awaits it.

        An object `jArray` is created for `Jarray` and the content from url is parsed.

        The `jObject` in `jArray` is counted and the `jArray` is printed and the count is returned.

## Task-5 Debugging DeadLock
Program.cs:

    DeadLockMethod():

        `SomeAsyncOperation` is called and awaited.

        The result is displayed.

    SomeAsyncOperation():

        Awaits a dealy of 10000 and returns "Hello World" string.

    Main():

        Awaits `DeadLockMethod()`.

Inference:

DeadLock arises in the `DeadLockMethod()`  when the `SomeAsyncOperation()` is awaited and in `SomeAsyncOperation()` there is a delay task awaited which waits for the main thread to come and execute the next lines but the main thread waits in the `DeadLockMethod` for the `SomeAsyncOperation()` to complete. 

The Deadlock is prevented by making the task `configureAwait(false)` and the next line does not necessarily wait for the main thread to execute.

## Task-6 Implementation of ConfigureAwait
AsynchronousMethods.cs:

    LongRunningProcess():

        A delay is simulated to represent a time consuming process.

        The task is made ConfigueAwait(false).

        The ThreadId is displayed before and after execution of every task.

    SecondLongProcess():

        An array of integers `arrayOfNumbers` is instantiated.

        The values are squared and the array is returned.

        The ThreadId before and after the task execution is displayed.
 
Program.cs:

    Main():

        Instantiates an array of integers `arrayOfNumbers` and awaits and gets result from `secondLongProcess()` and displays the array.


## Task-7 Difference between Async Void and Async Task with Exceptions.
AsynchronousMethods.cs:

    VoidMethod():

        Awaits a delay and throws an exception

    TaskMethod():

        Awaits a delay and throws exception.

Program.cs:

    Main():

        Try the `VoidMethod()` and catches the exception.

        Try the `TaskMethod()` and catch the exception.

Inference:

    The exception thrown by async void method cannot be caught and handled outside of the method, while the async task method exception can be caught.
