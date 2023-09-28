# ASSINGNMENT-7 
## TASK-1 Detecting Diagnosing Memory Issues
1. The memory issue in the code snippet is, the integers are added to the some list continously in loop. Due to arrays being added to list continously, after a limit OutOfMemoryException occurs.

2. The Diagnostic tools from the windows option in debug is used to diagnose the problem in the code. 
![Diagnosing OutofMemoryException](.\Images\7.1(MemoryException).png)

## TASK-2 Implementing Memory Management Best Practices.
1. The List is declared outside the loop, so the memory usage is constantly increasing and the OutofMemoryException occurs.The list can be declared inside the loop, which will manage the memory. The memory increases in the loop and for the next iteration,it begins again. Thus, the code is optimized.

2. The other ways for memory optimization are:
Deallocation of memory can be manually done, When the required operation is done.
![Memory Optimized](.\Images\7.2(MemeoryOptimized).png)

## TASK-3 
The diagnostic tool is used to check the memory usage of the optimized code.

    The optimized code uses memory efficiently,the memory usage increases for a iteration and then for the next itearation, a new list is created and the fall in the graph shows the list is dereferenced and the garbage is collected.
    
Before Optimization:

![Before Optimization](.\Images\7.3.1.(MemoryLeak).png)

After Optimization

![After Optimization](.\Images\7.3.2(optimizedcodde).png)