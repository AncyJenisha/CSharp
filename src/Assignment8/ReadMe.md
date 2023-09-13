# ASSIGNMENT-8
## TASK-1 Understanding and using value type and reference type in C#
    ReferenceTypeClass:
        It has the referencetypenumber assigned with value 1.
    Program Class:
        It has the main method, in which a valuetypenumber is assigned with value 1 and object is created and both are passed to a modifier method.
        The valuetypenumber and referencetypenumber in the ReferenceTypeClass are printed.
        
        The modifier  method increments both the referencetypenumber and valuetypenumber by 1.

Observation:
    The referencetype is incremented by 1. But, the valuetype remains the same.

## TASK-2 WORKING WITH THE STACK AND THE HEAP.
    ReferenceTypeClass:
        It has the method to create large array of integers.
    ValueTypeClass:
        It has the method to add numbers continously upto a large number of integers.
    Program Class:
        It calls the methods, OperationOnValueType and ArrayofIntegers.

Observation:
      The OperationOnValueType method uses very less heap.
      The value types directly contain data and they are stored in stack.

![Memory Usage for Value types](.\Images\8.2.1.HeapusageforReferencetype.png) 

      The ArrayofIntegers method uses more heap.
      The reference types stores the reference to thier data.

![Memory usage for Reference types](.\Images\8.2.2.HeapUsageforReferencetype.png)        

## TASK-3 Using Garbage Collection and Understanding its Impact on performance. 
    SampleClass:
        It is a empty class.
    Program Class:
        It has the main method, which continously creates objects for the class and calls the Garbage Collector for every 500 objects created.

Observation:
        When the GC is not called the heap size increases, when it is called it collects all the unused objects and frees the space.

![Heap Usage before using GC.Collect](.\Images\8.3.1.WithoutGarbageCollect.png)

![Heap usage using GC.collect](.\Images\8.3.2.UsingGarbageCollect.png)

## TASK-4 Implementing and understanding the IDisposable interface and the 'using' statement

    FileOperations Class:
        It has the method to read content and write content to a file.
        It inherits the Idisposable class.
        WriteToFile:
            It reads input from user and adds it to the file.
            It calls the dispose method after adding contents to close the file.
        ReadFromFile:
            It reads content from file and displays it.    
    Program Class:
        It calls the method to read contents from a file and the method to display contents from a file.

Observation:
    When using the "Using" keyword, the dispose method is called implicitly and it ensures the file is closed and disposed properly after using the file.