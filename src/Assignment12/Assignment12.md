# ASSIGNMENT-12 Generics And Collections
## Program.cs
Has main method which is the entry point of the program.
Main method:

    Gets the ChoiceOfCollection from the user.
    Gets the type of operation to be performed from the user and calls the method.

## ListOfBooks.cs
GenericListObject: 

    An object created for the GenericList class of generic type.

AddBooks():

    Gets the name of the book from the user.
    And it calls the Add method from the GenericList class, passing the name as a parameter.

RemoveBooks():

    Gets the index of the bookname to be removed.
    And it calls the Remove method from the GenericList class, passing the index as a parameter.


## GenericList.cs
Add():

    Adds a book name to the list.

RemoveAt():

    Removes the book name at the recieved index.

DisplayBooKlist():

    Displays the elements of the booklist.


## Queue.cs
QueueOfNames:

    Is an object created for the GenericQueue class.

EnqueueNames():

    Reads the name to be added to the queue.
    Calls the AddName() method from the GenericQueue class passing the name as a parameter.

DequeueNames():

    Calls the RemoveName() method from the GenericQueue class.


## GenericQueue.cs
GenericQueueOfNames:

    Is a Generic list that has the names in generic type.

QueueCount:

    Has the count of the GenericQueueOfNames.

AddName():

    Adds the name to the queue.

RemoveName():

    Removes the name from the queue.

DisplayName():

    Displays all the elements from the queue.


## StackOfCharacters.cs
StackOfCharactersObject:

    Is an object for the GenericStack class.

PushCharacterToStack():

    Gets the character to be pushed to the stack.
    Calls the AddCharacterToStack() method from the GenericStack class.

PopCharacterToStack():

    If Stack count is greater than zero it calls the RemoveCharacters() from the GenericStack class.
    Else it displays a message saying the stack is empty.

## GenericStack.cs
GenericStackOfCharacters:

    Is a stack of generic type to store characters.

GenericStackCount:

    Has the count of the GenericStackOfCharacters.

AddCharactersToStacK():

    Push the character to the stack.

RemoveCharacter():

    Pop a character from the stack.

DisplayCharacters():

    Displays all the characters from the stack.


## DictionaryOfStudentDetails.cs
StudentDetails:

    Is an object for the GenericDictionary class.

AddDetails():

    Gets the Student name as Key and Grade as value.
    It calls the AddStudentDetails() method passing the student name and grade as parameter.

RemoveDetails():

    Gets the student name to be removed from the dictionary.
    Calls the RemoveStudentDetails() from the GenericDictionary class passing the name to be removed as a parameter.


## GenericDictionary.cs
GenericDictionaryOfStudentDetals:

    Has the student name and grade as key value pair of the dictionary in generic type.

AddStudentDetails():

    Adds the studentName and studentGrade as key value pair to the dictionary.

RemoveStudentDetails():

    Checks if the dictionary contains the given key and removes it if present.
    Else it displays a message asking to enter the correct student name.

DisplayStudentDetails():

    Displays all the student name and grade in the dictionary.

## SumCalculator.cs
SumOfElementsOfCollection():

    Gives the sum of all the elements of the collection passed as input parameter.

## DictionaryGenerator.cs
CreateDictionary():

    Gets a dictionary and converts it into readonly dictionary type.