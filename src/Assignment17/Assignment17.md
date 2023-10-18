# ASSIGNMENT-17 INTRODUCTION TO FILES AND STREAMS

## Task1 

The project has the following features.

1. **File Writing**
   - Synchronous file writing.

   - Asynchronous file writing.

 
2. **File Reading**
   - Synchronous file reading.

   - Synchronous file reading using a buffered stream.

   - Asynchronous file reading using a buffered stream.

 
3. **File Modification**
   - Synchronous file content modification (capitalization).

   - Asynchronous file content modification (capitalization).


`Program.cs`

This file contains the entry point of the application. It calls methods to demonstrate file writing, reading, and modification.
 

`FileWriters.cs`

This file contains methods for writing content to a file. It includes both synchronous and asynchronous write operations.

`WriteToFile()`: It opens the filestream and writes content to it till the file size becomes 1GB. It checks the time taken to write to the file by using stopwatch.

 
`FileReader.cs`

This file provides methods to read content from a file. It includes options for synchronous file reading and synchronous reading using a buffered stream. Additionally, it offers asynchronous file reading using a buffered stream.

`ReadFromFile()`: It opens a filestream to open a file "Assignment17.txt" and read it by decoding the contents to string.

`ReadUsingBufferedStream()`: It opens a filestream and a bufferedstream and reads the content from file using a byte array as buffer.


`FileModifier.cs`

This file offers methods to modify file content. It demonstrates both synchronous and asynchronous content modification by capitalizing the content and saving it to a new file.

`AddCapitalizedContentToFile()`: It opens a filestream and a bufferedstream to read the file in byte array and decodes it to string and change the contents to upper case and writes it to another filestream using bufferedstream.


## Task2 Asynchronous File Operations

`FileWriter.cs`

`WriteToFileAsync()`: It opens a filestream and writes the message to it asynchronously.


`FileReader.cs`

`ReadUsingBufferedStreamAsync()`: It opens a filestream and a bufferedstream to read contents from the file by decoding it.

`FileModifier.cs`

`AddCapitalizedContentToFile()`: It opens a filestream and a bufferedstream to read from a file asynchronously and decode it to string and writes it to another file decoding it to bytes.

**INFERENCE**

The time taken to perform file operations asynchronously is less when compared to doing it synchronously.

![Comparison of Time to perform file operations synchronously and asynchronously](.\Images\17.1.TimeComparison.png)

## Task3 Memory Leak Investigator

The code demonstrates a simple file write and read operation and investigate memory leaks. The code explores how memory is allocated and released during file I/O operations, with a focus on memory management and potential memory leaks.

## Program.cs 

This file contains the entry point of the application.

The `Program` class contains a `Main` method, which is the starting point of the application. The primary goal of this program is to perform a file write and read operation and measure the time it takes. 

`Main()`
1. **File Writing**: It writes the string "This is some test data" to a file named "CodeOptimization.txt" using an `FileStream`. This operation is intended to simulate a file write operation.

2. **File Reading**: It reads the content of the "CodeOptimization.txt" file using another `FileStream`. The content is read in chunks and printed to the console, which simulates a file read operation.

3. **Memory Leak Investigation**: The code includes a timer to measure the time it takes to complete both the write and read operations. This is useful for investigating potential memory leaks or excessive memory usage.

4. **Memory Usage**: During the read operation, it displays the content of the file. The code is also designed to print the memory usage of the buffer used to read the file content.

### Investigating Memory Leaks

This code serves as a starting point for investigating memory leaks during file I/O operations. It's important to analyze the memory behavior and usage during such operations, as excessive memory allocation without proper cleanup can lead to memory leaks.

## TASK4 Logging System for Multiple Users

This project demonstrates a simple logging system for multiple users.
It allows parallel logging of error messages to separate log files.

## Program.cs

This file contains the entry point of the application. The `Program` class initiates parallel execution of error logging by calling the `Logger.LogError` method with error messages. It generates log files (e.g., Log1.txt, Log2.txt, etc.) and logs the "Error" message into these files.

## Logger.cs

The `Logger` class provides the functionality to log error messages. It follows a singleton pattern to ensure thread safety in creating a single instance of the logger.

### Methods:

- `LogError(string filepath, string message)`: Logs an error message to a specified file path. It takes two parameters: the file path as a string and the error message. The method ensures thread safety for writing to the log files by using a lock.