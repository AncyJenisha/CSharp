# ASSIGNMENT-11 AUTOMATED TESTING
## Task-1 Setting Up a Test Project Using Xunit
A XunitTestingAssignment is created and a class CalculatorTests is created with functions to tests the mathematical functions to be created for the calculator class.

Test Driven Developement:
    Test Driven Development is the software development process where, the requirements are converted into test cases before the software is fully developed and it is repeatedly tested while development to check its functionality.

## Task-2 Writing the Application to Be Tested.
 A Calculator application is created with the mathematical functionalities like addition, subtraction, multiplication and division.
 A OrderService application is created to put products for sale and buy from the list of products for sale. It has functions to place order, remove it and display the order.

## Task-3 Writing Different Types of Tests
Unit Test:
    Unit test is written to check the smallest functioning part of the program.
Data Driven Test:
    Data driven test depends on the input and output by comparing the values of the expected output and actual output.

## Task-4 Understanding and applying Testing Concepts
AAA - Arrange Act Assert
Arrange: The step to setup the code before testing. It is organising code before testing.
Act: The part where we execute the test.
Assert: The comparison between the result of the test and the expected output.

## Task-5 Using Xunits Advanced Features
Tests of different classes run parallely and the tests of same class run serially.

## Task-6 Understanding Assertions in Xunit
Assert checks if a condition passed as an argument and if the condition evaluates to true no action is executed and if it evaluates to false the program breaks, when in debug mode.

`Assert.Equal`: To compare two instances for equality.

`Assert.Throws`: Checks if the method execution throws an exception of the same type.

## Program.cs
    The Program class has the main method.
`main` method :
    It gets two numbers and the choice of service from the user and calls the method to perform the operation.
    It gets the choice of operation for the calculation service.
   
 ## Product.cs
    Product class has properties.
    Id: Has the Serial number of the product in int.
    ProductName: Has the name of the product in string.
    Quantity: Has the quantity of the product in int.
    Price: Has the price of the product in double.

## EnumOptions.cs
    Has enum for ChoiceOfService, ChoiceOfMathOperations, OrderServiceUser, OptionsForSellers, OptionsForBuyers.
`ChoiceOfService` : Has the options for the type of services.

 `ChoiceOfMathOperation`: Has the different type of mathematical operations. 

`OrderServiceUser` : Has the options for different type of users using order Service.

`OptonsForSellers`: Has the options for operations performed by the sellers.

`OptionsForBuyers`: Has the options for operations performed by the buyers.

## OrderService.cs
    It gets the type of user for the Order Service.

    It gets the options to chose the opertions by the users of the order service and calls the method.

## SellerService.cs
    The SellerService class has the methods for the options for the sellers.

`AddProducts`: Gets the product details and adds the product to the list.

`DisplayProducts`: Displays the list of `ProductForSaleList`.

`DeleteProducts`: Deletes the Product from the `ProductForSaleList`.

## BuyerService.cs
    The BuyerService class has the methods for the options for the buyers.

`AddProductsToCart`: Adds the product from the `ProductForSaleList` to the `OrderedProductsList` with the `id` entered by user.

`DisplayOrder`: Displays the `ProductForSaleList`.

`RemoveFromCart`: Removes the product from the `OrderedProductsList` with the `id` entered by user.