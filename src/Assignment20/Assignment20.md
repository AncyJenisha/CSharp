# Reflection 

The Reflection Project includes the following features:

1.  **AssemblyInspector.cs**: This class allows to inspect an assembly, get its types, properties, methods, fields, and events.

GetAssemblyDetails(): This method gets the MemberType property with an array of MemberInfo objects by fetching all the types within the loaded assembly.

GetPropertyDetails(): This method gets the PropertyTypes property by fetching all the properties of the types within the assembly.

GetMethodDetails(): This method gets the MethodType property by fetching all the methods of the types within the assembly.

GetFieldDetails(): This method gets the FieldTypes property by fetching all the fields of the types within the assembly.

GetEventDetails(): This method gets the EventTypes property by fetching all the events of the types within the assembly.


2. **DynamicMethodInvoker.cs**: This class enables you to invoke methods of objects dynamically.

InvokeMethod(object obj): This method is responsible for invoking methods from the array of MethodInfo objects provided. It takes an obj parameter, which is the object of the class whose methods need to be invoked.


3. **DynamicObjectInspector.cs**: This class helps you inspect and change the properties of an object dynamically.

InspectDynamicObject(object obj): This method inspects the properties of the provided object and displays their names and values.
It takes an obj parameter, which is the object to be inspected.
It prints the type of the object (obj.GetType()) to the console.
It gets the Properties property by fetching all the properties of the object's type using obj.GetType().GetProperties().
It then iterates through the properties in the Properties array, prints each property's name and its corresponding value using property.Name and property.GetValue(obj), and displays this information on the console.

SetValueToProperty(object obj, string name): This method sets a value to a specific property of the provided object.
It takes two parameters:
obj: The object whose property needs to be changed.
name: The value to be set to the property.
Within the method, it retrieves the property using obj.GetType().GetProperty(name), where name is the name of the property to be changed.
It sets the value of the property to the provided name value using propertyInfo.SetValue(obj, name, null).


4. **Employee.cs**: An example class with properties and methods for demonstration.

CalculateBonus(): This method calculates the bonus for the employee based on their salary. It returns the bonus value as a floating-point number. The bonus is calculated as 25% (0.25 times) of the employee's salary.

PrintDetails(): This method prints the details of the employee to the console. It displays the employee's name, salary, and bonus by calling the CalculateBonus method. The details are printed in a formatted string.


5. **IBankAccount.cs and ICheckingAccount.cs**: Interfaces and classes demonstrating usage of interfaces.

IBankAccount Interface:

This interface represents the basic structure and methods for a bank account.

AccountNumber (Property): This property represents the account number as a string. It has both a getter and a setter, allowing you to get and set the account number.

Amount (Property): This property represents the amount associated with the account as a floating-point value (presumably the balance). It has both a getter and a setter.

Balance (Property): This property represents the current balance of the account as a floating-point value. It has both a getter and a setter.

WithdrawAmount(float amount) (Method): This method is used to withdraw a specified amount from the account. The amount parameter represents the amount to be withdrawn. The method is declared but not implemented in the interface, which means that classes implementing this interface must provide their own implementation.

DepositAmount(float amount) (Method): This method is used to deposit a specified amount into the account. It increases the balance by the deposited amount. The method is implemented in the interface with default behavior, which can be overridden by implementing classes.

CheckBalance() (Method): This method is used to display the account number and the current balance. It prints these details to the console. Like DepositAmount, this method is implemented with default behavior that can be overridden.

ICheckingAccount Class:

This class implements the IBankAccount interface, representing a checking account. It allows withdrawals with certain restrictions (insufficient balance).

Constructors: The class defines two constructors. One is parameterless, and the other takes an accountNumber parameter and sets it to the AccountNumber property.

Property Overrides: The class overrides the Amount and Balance properties defined in the IBankAccount interface. The Balance property is initialized with a default value of 25,000.

WithdrawAmount(float amount) (Method): This method is an implementation of the withdrawal operation for a checking account. It checks if the current balance is sufficient to allow the withdrawal. If the balance is greater than or equal to the specified amount, it deducts the amount from the balance and prints the new balance. Otherwise, it prints a message indicating insufficient balance.

The IBankAccount interface defines a default bank account structure, and the ICheckingAccount class implements this structure specifically for checking accounts, including balance management and withdrawal restrictions.

6. **ImplementPlugin.cs**: This class helps you discover and call methods that implement specific interfaces from an assembly.

GetAssemblyDetails(): This method is responsible for getting the MemberType property with an array of types found in the loaded assembly (the executable assembly). It does this by calling _assembly.GetTypes(), which retrieves all the types within the assembly.

GetInterfaces(): This method is used to search for a specific interface named "IBankAccount" among the types in the assembly. If it finds an interface with that name, it assigns it to the InterfaceType property.

CallMethodsThroughPlugin(): This method is designed to invoke a particular method, "WithdrawAmount", from an object instance that implements the "IBankAccount" interface.

It creates an instance of a class that implements the "IBankAccount" interface using Activator.CreateInstance(this.InterfaceType). This assumes that the interface corresponds to a class that can be instantiated.

It retrieves the "WithdrawAmount" method from the InterfaceType using this.InterfaceType.GetMethod("WithdrawAmount").
It then invokes the "WithdrawAmount" method on the created instance with an argument of 1500F. The result of this method invocation is stored in the invoked variable, but this value is not used or returned in the provided code.

7. **InputValidator.cs**: A utility class for validating user input.

GetIntegerInput() : It declares an integer variable number to store the final integer value.
It prompts the user to enter a value by displaying the message "Enter valid Number."
Once a valid integer is obtained, the method returns the number value.

8. **OperationOptions.cs**: An enum that defines options for the toolkit's menu.

OperationOptions Enumeration:

The OperationOptions enumeration represents a set of named constants, each corresponding to a specific operation that can be performed in a program.

Enumeration Members:

InspectAssemblyMetaData - Represents the option to call methods for inspecting assembly metadata.

InspectDynamicObject - Represents the option to call a method to inspect a dynamic object.

SetValueToProperty - Represents the option to call a method to set a value to a property of an object.

InspectInterfaces - Represents the option to call a method to get the types that implement specific interfaces.

SerializeObject - Represents the option to serialize an object and display the serialized data.

Exit - Represents the option to exit the program.


9. **PropertyDisplayer.cs**: A class for displaying information about types, properties, methods, and fields.

DisplayMemberInformation() : This method takes an array of MemberInfo objects named assemblyTypes as a parameter.
It iterates through the assemblyTypes array and displays the names of types within the assembly.

DisplayPropertyInformation() : This method takes an array of PropertyInfo objects named memberProperties as a parameter.
It iterates through the memberProperties array and displays information about properties within the types.

DisplayMethodInformation() : This method takes an array of MemberInfo objects named methodNames as a parameter.
It iterates through the methodNames array and displays the names of methods within the types.

DisplayFieldInformation() : This method takes an array of FieldInfo objects named fields as a parameter.
It checks the length of the fields array and determines whether there are fields to display.
If fields are present, it iterates through the fields array and displays the names of fields within the types.

DisplayPropertyValue() : This method takes a PropertyInfo object named propertyInfo as a parameter.
It creates an instance of the Employee class.
It displays the value of a property specified by the propertyInfo parameter for the employee instance.

DisplayInterfaceTypes(): This method takes a Type object named interfaceType as a parameter.
It displays information about the types that use the specified interface, which is represented by the interfaceType parameter.


10. **Serializer.cs**: This class allows you to serialize an object and display its properties.

SerializeObject() : This method is responsible for serializing an object and displaying its properties in a JSON-like format.

It takes an object named obj as a parameter, representing the object to be serialized.

Inside the method, it first checks if the obj is not null.

It then retrieves the properties of the obj using reflection. It does so by getting the type of the object (obj.GetType()), accessing its type information (GetTypeInfo()), and then fetching its properties (GetProperties()). These properties are stored in the PropertyTypes array.

The method iterates through the PropertyTypes array, and for each property, it extracts the property's name and value. It does this using property.Name and property.GetValue(obj), respectively.

For each property, it prints a line in the format: {"propertyName" : "propertyValue"}.

11. **Program.cs**

Main() : The Main method is the entry point for the program, where the program execution begins. It does not accept any command-line arguments since it has an empty parameter list.
