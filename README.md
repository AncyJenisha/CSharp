# ASSINGMENT-1
    For the practical excercise  a CSharp console application needs to created which has a class 'MathUtils' containing the methods like add, subtract, Multiply, Divide that performs the arithmetic operations on the integers recived from user through the main class and displays the result.

 ## MathUtils Class
        1. It has methods like add, subtract, multiply, divide to perform the arithmetic operations.
        2. It recieves the two integers as input parameters to perform the functions.
        3. The methods displays the results of the operations.
## Main Class
        1. The main class recieves two integers from user as input.
        2. The main class has GetInput method to recieve an number as a string and converts it to an integer.
        3. It displays the options for the different arithmetic operations.
        4. It recives the user's perferred aithemtic operation as option.
        5. The method for preferred arithemetic operations are called based on the option.
 
 # ASSINGMENT-2
  ## TASK-5
  For the practical excercise a console contact manager application is to be created which allows user to store and manage thier contacts.

  ## Program.cs
  ## Main Class 
        1. It displays the functions of the application as options.
        2. The displayed options are Add New Contact, Display, Search, Edit and Delete.
        2. It reads the option entered by user and calls the method to  perform the task.

 ## enum.cs
        It has the enum for the functions to be performed and an enum for the options to edit.
  
  ## Contacts.cs
        1. It has the contact class instantiated.
        Id: Uses the index of the list to store the serial number of the contacts and stores it.
        Name: Gets the name entered by user and stores it.
        PhoneNumber: Gets the number entered by user and stores it.
        EmailId: Gets the email entered by user and stores it.
        Notes: Gets the notes entered by user and stores it.

  ## ProgramHelpers.cs
        1. It has the methods that performs the functions of the application.
        AddNewContact:
                 This method when called adds new contact as an object to the contactList.
                 The attributes of the contact object are recieved from user.
                 It reads the name from user, validates it by calling a method for validation of name and stores it.
                 It reads the phone number from user, validates it by calling a method for validation of phone number and stores it.
                 It reads the EmailId from user, validates it by calling a method for validation and stores it.
                 It reads the notes entered by user and stores it.

        DisplayContact:
                This method when called displays all the contacts from the conntactList.

        SearchContact:
                This method when called asks for a name to search as 'nameToSearch'.
                It then iterates through the list to search for the contacts that contains 'nameToSearch' in thier string 'Name' and adds it to a another list 'searchList'.
                Then it calls the 'DisplayContact' method to display the 'searchList'.

        DeleteContact:
                This method when called displays all the contacts and asks for the Id of the contact to be deleted.
                With the Id the contact is deleted and the id of the remaining contacts are changed to be in order.

        EditContact:
                This method when called asks for the Id of the contact to be edited.
                Then it displays the fields of the contact as options to edit.
                The method reads the option and asks for the change to be made in the field of the contact.
                It checks for validation and stores the changes.

## InputHelpers.cs
        GetInput:
                This method gets input as string and converts it into integer and checks if its valid.

        GetStringInput:
                The method gets input and displays message if the string is null or empty.


## Validators.cs
        It has the methods to check if the input entered by user is valid.
        nameValidate:
                This method checks if the name entered by user is valid by checking it with a regular expression.

        emailValidate:
                This method checks if the email entered by user is valid by checking it with a regular expression.

        phoneValidate:
                This method checks if the phone number entered by user is valid.

        namepattern:
                It has the format for the name. It is compared with the name entered by user.

        emailpattern:
                It has the format for the email and is compared with the email to be entered by user.

        phonepattern:
                It has the format for the phone number, which is compared to the number entered by user.

 
# ASSIGNMENT-5
 For the task a solution with multiple console application is created and its dependancies and build order is managed.

 ## GreetingApp
        It has the main method and it is the startup project for the solution.
        The main method prints a message to greet the user.
        It is dependent on MathApp.
        The main method calls the Readinput method.

## MathApp
        It has the Methods to get input and calls the method based on the choice entered by user for the math operation to be performed.
        It is dependent on DisplayApp and ValidatorApp.

###     MathUtilis
                It reads the two numbers from the user for performing the math operation and the choice of operation from user. It also has the methods for different mathematical operations.
                The methods for math operations performs the operations and passes the result to the display method in Task5DisplayApp.
                It validates the input recieved from user by calling methods in ValidatorApp.

###     Choice
                It has the switch case and enum for the options of mathematical operations
                enum options:
                        It has the list of math operations for the user to choose.
                
                ChoiceofMathoperation:
                        It has the switch case which gets the option enetered by user and calls the respective method, which is in MathUtilis.

## DislayApp
        It has the method to recieve the result from the math operation as input and displays it as result.
        It is dependent on the UtilityApp to call the method to display the thankyou message after using the console application.

## UtilityApp
        It has the method to display the thankyou message at the end of the application.

## ValidationApp
        It has the methods to validate the input as integer and float.
        GetInput:
                It reads input from user and coverts it into float.
        
        GetIntegerInput:
                It reads input from user and converts it into integer.

## Circular Dependancy:

        The project MathApp is dependent on the DisplayApp and it calls a method in the DisplayApp to display the result of math operations.
        It creates a circular dependency and can be solved by creating a new project validators and having the getinput methods there and making it a dependency of MathApp.

![Build order](.\Images\BuildOrder(task5).png)


# ASSIGNMENT - 6
## Task-1 SHAPE HIERARCHY
SHAPES (Abstract class):
        Properties:
                1.Color of the shape as string.
        Methods:
                GetArea method as abstract that returns the area as a float value.
                PrintDetails method as abstract that prints the details of the shape.
        
        RECTANGLE :
                It is the class that inherits the Shapes class.
                It gets the length, width and color and sets as property of the class.
                It has methods overriden for the GetArea() and PrintDetails().
                GetArea()
                        It multiplies the length and width and returns the area as float value.

                PrintDetails()
                        It prints the Shape type, color and area of the shape.

        CIRCLE:
                It is the class that inherits the Shapes class.
                It gets the color, radius and sets them as property of the class.
                It has methods overriden for the GetArea() and PrintDetails().
                GetArea()
                        It multiplies the radius with 6.24 to return the area as float.
                
                PrintDetails()
                        It prints the shape type, color and area of the shape.

        INPUTREADERS:
                It has the methods to read the input enetered by the user and validate it.
                GetFloatInput():
                        It reads the input entered by the user and converts it into float.
                GetStringInput():
                        It reads the input entered by user and checks if it is not null.
        
        PROGRAM:
                It has the main method.
                Main():
                        It asks for input from user.
                        It reads the input for the color, width, length from user.
                        An object is created to 
                        The PrintDetails() method of Rectangle class is called to display the details.
                        It reads the input for the color, radius from user.
                        An object is created
                        The PrintDetails() method of Circle class is called to display the details.


## TASK-2 EMPLOYEE HIERARCHY
EMPLOYEE (Abstract class)
        Properties:
                1.Name of the employee as string.
                2.Salary of the employee as float.
        Methods:
                1.CalculateBonus():
                        It is an abstract method that returns the bonus as a float value.
                2.PrintDetails():
                        It is an abstract method.

MANAGER:
        This class inherits the employee class.
        It gets the name, salary and sets as property.
        It has methods overriden for CalculateBonus() and PrintDetails().
        CalculateBonus():
                It calculates the bonus by multiplying 0.25 with the salary of the manager.
        PrintDetails():
                It displays the name, salary, position and bonus of the manager.

DEVELOPER:
        This class inherits the employee class.
        It gets the name, salary and sets as property.
        It has methods overwritten for CalculateBonus() and PrintDetails()
        CalculateBonus():
                It calculates the bonus by multiplying 0.15 with the salary of the developer.
        PrintDetails():
                It displays the name,salary, position and bonus of the developer.

INPUTREADER:
        It has methods to read input from user.
        GetFloatInput():
                It gets the input as string and converts as float.
        GetIntegerInput():
                It gets the input as string from user and converts into integer.
        GetStringInput():
                It reads the string from user and checks if it is not null.

OPTIONS:
        It has the enum for the type of employees in it and an option to exit.

PROGRAM:
        It has the main method.
        Main():
                It displays the type of employee and asks the user to select the type .
                It creates the object based on ethe choice of the user.
                It reads the name and salary from user.
                An object for the class choosen by the user is created with the details as properties of class.
                The PrintDetails() method is called which displays the details of the employee.


## TASK-3 BANKING SYSTEM
BANKACCOUNT(Abstract class):
        Properties:
                1.Account number as string.
                2.Balance amount of the account as float value.
                3.Amount to be withdrawn or deposited as float value.
        Methods:
                1.DepositAmount()
                        The method gets the amount and adds it to the balance and returns the balance.
                2.WithdrawAmount()
                        This method is abstract.
                        It gets the amount and returns the balance as float value.
                3.CheckBalance()
                        This method displays the account number and balance of the account.
                
SAVINGSACCOUNT:
        This class inherits the BankAccount.
        It gets the account number and sets it as property of class.
        It has method overwritten for the WithdrawAmount().
        WithdrawAmount():
                It gets the amount to be withdrawn from user and checks if after withdrawal the account has a minimum balance.
                If the account has the minimum balance, it deducts the amount from the balance and displays a message.
                If the account does note have the sufficient balance, it displays a message saying the acccount does not have sufficient balance.
        
CHECKINGACCOUNT:
        This class inherits the BankAccount.
        It gets the account number and sets it as property of class.
        It has method overwritten for the WithdrawAmount()
        WithdrawAmount():
                It gets the amount to be withdrawn and checks if the balance is more than the amount.
                If the balance is more, it deducts the amount and returns the balance and displays a message.
                If the balance is less, a message saying the account does not have the sufficent balance is displayed.

INPUTREADERS:
        It has methods to read input from user.
        GetFloatInput():
                It gets the input as string and converts as float.
        GetIntegerInput():
                It gets the input as string from user and converts into integer.
        GetStringInput():
                It reads the string from user and checks if it is not null.               

EnumOptions:
        It has the enum used in the main program.
        AccounType:
                Savingsaccount: It creates an object for SavingsAccount in switch case.
                CheckingAccount: It creates an object for CheckingAccount in switch case.
                Exit: It exits the switch case.
        AccountOptions:
                Deposit:It calls the DepositAmount method.
                Withdrawal:It calls the WithdrawAmount method.
                Checkbalance:It calls the method to display the balance of the account. 
                Exit:It exits the switch case.

PROGRAM:
        It gets the input from user.
        An object is creaed based on the choice of user.
        Method to withdraw or deposite is called based on the user choice.
        DepositAmount() method adds the amount entered by the user to the balance of the respective account.
        WithdrawAmount() method deducts the amount entered by the user from the balance of the respective account.
        

# ASSIGNMENT-11 AUTOMATED TESTING
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