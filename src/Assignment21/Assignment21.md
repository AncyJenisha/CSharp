# ASSIGNMENT 21  NUGET PACKAGES

# MyMath Library
The primary purpose of this library and console application is to calculate and display Fibonacci sequences.

To use the library:

Create an instance of the FibonacciCalculator class from the MyMathLibrary namespace.

Use the CalculateFibonacci method to generate a Fibonacci sequence up to the desired length.

Display the resulting Fibonacci sequence.

## MyMath Library

The code has the MyMathLibrary namespace. Inside this namespace, it uses two namespaces: MathNet.Numerics and System.Numerics. The MathNet.Numerics namespace is used to calculate the Fibonacci sequence, and the System.Numerics namespace is used to work with large integers (i.e., BigInteger).
FibonacciCalculator Class:

The FibonacciCalculator class contains methods for generating a Fibonacci sequence.

CalculateFibonacci():

This method is used to calculate and return a Fibonacci sequence up to a specified length.
It takes an integer parameter number, which represents the desired length of the Fibonacci sequence.
It returns an array of BigInteger values, representing the generated Fibonacci sequence.
Method Implementation:

Inside the CalculateFibonacci method, it calls the Generate.Fibonacci method from the MathNet.Numerics library.

This method generates a Fibonacci sequence up to the specified length (number) and stores it in the fibonacciSequence variable.

The method then returns this generated Fibonacci sequence as an array of BigInteger.

Creating a Nuget package:

A class library project, `MyMathLibrary` is created and the dependancy is added to the <dependency> tag on the `.nuspec` file.

The class library is checked for its functionality.

nuget.exe is installed within the class library folder.

The class project is made to be a nuget package.

## My Console Application

The code has a program class and a input validator class which validates the user input.

**Program.cs**

`Main()` : 

The main is the entry of the program. The main gets the size of the fibonacci sequence and displays the fibonacci sequence.

It uses the MyMathLibrary nuget package's method to generate the fibonacci sequence.

Using the created nuget package:

The created nuget package is published by using BaGet and setting up a nuget API key topublish it.

Add the nuget package `MyMathLibrary` from MyPackages as reference and use the methods in the nuget package.