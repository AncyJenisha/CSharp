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

