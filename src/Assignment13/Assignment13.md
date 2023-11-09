# ASSIGNMENT 13 ADVANCED LANGUAGE FEATURES
## Task-1 Events & Delegates
Program.cs:

    GreetMessage():

        Prints Greeting message.

    Main():

        An insance of Notifier Delegate is created.
        The GreetMessage() is subscribed to the event OnAction.
        The OnActionPerformed() is called with a message as a parameter.


Notifier.cs:

    Notify:

        A delegate which points to functions getting a string message as an input parameter and returns void.

    OnAction:

        An event of type Notify.

    OnActionPerformed():

        This method invokes the event OnAction with the message recieved as input parameter.


## Task-2 Use and difference of Dynamic and Var keywords.
Program.cs:

    Main():

        `firstNumber` is declared as var and assigneda value of 13.

         Since, it is declared as `var`, its type cannot be changed when it is tried to assign a string.
        
        `secondNumber` is declared as dynamic and assigned a value of 13. It is reassigned with string `Thirteen` and the value of `secondNumber` changes to string. 

## Task-3 Implementing Anonymous Mthods.
Program.cs:

    Operations:

        The delegate points to a method that gets an array of integers as input parameter and returns void.

    Main():

        Gets the integer elements for the `arrayToBeSorted`.
        An instance for delegate `Operations` is created with the an anonymous function which uses `Array.Sort` to sort the array passed as input.
        The delegate is called with the `arrayToBeSorted` and the sorted array is displayed.


## Task-4 Lambda Expressions and Statements
Program.cs:

     Main():

        A list `listOfNumbers` is declared and its elements are recieved from user.
        `filteredData` is made ienumerable and the elements from `listOfNumbers` which are divisible by 2 are added to it.
        A list `filteredResult` is declared where a number from `listOfNumbers` which are divisible by 2 are squared.
        The `filteredResult` is displayed.

    
## Task-5 Delegates to Sort
Product.cs:

    ProductName:
    
        The name of the product as string.
    
    Category:
    
        The category the product belongs to is given as string.
    
    Price:
    
        The price of the product as float.


    
ProductsSorters.cs:
    
    SortDelegate:
    
        A delegate that points to a function that gets two Products and returns int.

    SortByName():

        Gets two Products as input and compare the Product name and arrange them in alphabetical order.

    SortByCategory():

        Gets two Products from user and compares their category and arrange them in alphabetical order.

    SortByPrice():

        Gets two Products from user and compares thier Price and arrange them in ascending order.

    SortAndDisplay():

        It gets a delegate and a list `listOfProducts` as input parameter.

        It sorts the list by taking two consecutive Product object and sorts it in iterative way and it displays the sorted `listOfProducts`.

SortingType.cs

    SortingType:

        The enum has the different sorting types to be used in switch case.

Program.cs:

    Main():

        Gets the numeber of elements of the list from the user and gets the elements from the user for the `ProductsList`. 

        Gets the type of sorting to sort the Product list.

        Calls the `SortAndDisplay()` method passing the ProductList and the type of sorting method with reference to the delegate ProductSorters.

        
## Task-6 Records

Book.cs:

    Book:

        Record that has  strings `title` `author` and int `isbn`.

    DisplayBookRecord():

            It gets a Book object as input paramter.

            It deconstructs the Book object and prints the details of the book.

Program.cs:

    Main():

        Creates three objects of Book `firstBook`, `secondBook`, `thirdBook`.
        if the `firstBook` and `thirdBook` are equal it displays a message saying they are equal, else it says they are not equal.

        `fourthBook` is created based on `secondBook` and its title and author are changed.

        The `secondBook` and `fourthBook` are displayed and from this it is infered that the `secondBook` value doesn't change.

## Task-7 Advanced Pattern Matching
Shape.cs:

    The base class for the other shape

    CalculateArea():
        Abstract method for calculating area and returns the area as float.

Rectangle.cs:

    Length:

        Gets or sets the length of the rectangle as float.

    Breadth:
    
        Gets or sets the breadth of the rectangle as float.

    CalculateArea():

        Calculates the area by multiplying length and breadth and returns area as float value.

Circle.cs:

    Radius:

        Gets or sets the radius of circle in float value.

    CalculateArea():

        Calculates area by multiplying the radius with 0.628 and returns the area as float value.

Rectangle.cs:

    Length:

        Gets or sets length of the rectangle as float value.

    Breadth:

        Gets or sets the breadth of the rectangle as float value.

    CalculateArea():

        Calculates area by multiplying length and breadth and returns area as float.

    
Program.cs:

    Main():

        Creates objects for `Circle`, `Rectangle`, `Triangle and adds it to list `listOfShapes`.

        Calls the `DisplayShapeDetails()` method for each element of the list of objects `ListOfShapes`.