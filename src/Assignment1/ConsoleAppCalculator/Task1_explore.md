# TASK-1 

## 1. .NET and its purpose 

    .NET is an open-source cross platform for developing different kinds of desktop, web, mobile applications that can run on any operating system. It contains tools, libraries, languages that support modern high-performance software development.  

 

## 2.  Key Components Of .NET
###	Framework Class Library (FCL) 
    It is a library of classes and services that supports different types of applications.  

###	Common Language Runtime (CLR) 
	Run time environment that executes code in any .NET supported languages. 

 

## 3. Common Language Runtime vs Common Type System 

	The CLI includes Common Type System (CTS) and Common Language Specification (CLS). The CLI applications are converted into Intermediate Language (IL), which is then compiled into target machine language by CLR. 

	The CTS provides guidelines for declaring, using, and managing data type at runtime. It offers cross language communication.  

 

## 4. Role of Global Assembly Cache (GAC) in .NET 
    .NET assemblies explicitly intended for shared utilization across all applications in all systems. By registering assemblies in the Global Assembly Cache (GAC), they can be shared among multiple applications in the machine, which promotes code reuse and helps avoid duplication. 

 
## 5. Value type vs Reference type 
### Value Type: 
    They hold the actual value. They are stored in stack and include primitive datatypes. When passing value types, a copy of data is made. 

### Reference Type:
    They hold the reference of the data. The data is stored in heap and Reference type include array and structure stored in heap and they have their memory managed by garbage collector. 

 
## 6. Garbage Collection and its advantage 
    Garbage Collection is an automatic memory management process that hepls in manage memory by reclaiming memory occupied by objects that are no longer used. It works by identifing and cleaning objects that are no longer referenced and reachable.
    The advantages of Garbage collection are:
     1. Memeory Management
     2. Dynamic allocation of memory 
     3. Prevention of dangling memory
     4. Improved performance 
     5. simplified code

## 7. Globalization and Localization features in .NET
    Globalization allows to design applications that can be easily localized by seperating user interface elements from code, formating the data/time/numbers according to cultural norms and handling language specific norms.
    
    Localization involves transulating the elements and adapting the application to specific cultures. 

## 8. Role of Common Intermediate Language and Just In Time Compiler
    Common Intermediate Language (CIL) is an Intermediate Language (IL). The high level programming language are compiled into Intermediate Language, which allows different .NET programming language to be compiled in the same environment enabling interoperability and cross compatibility.

    Just In Time (JIT) Compiler converts Common Intermediate Language to native machine language just before execution. This improves performance by adapting code to specific hardware.