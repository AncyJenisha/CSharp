# HANDS ON WITH VISUAL STUDIO
## TASK -1 
    1.  The solution explorer:
        The solution  explorer shows the hierarchy of files and folders in the solution, project or code folder.
        The files from the solution explorer is selected to view it on the editor.
    2.  The Editor window:
        The editor window shows the contents of the file and with it we can edit and work on our file.
    3.  Menu bar:
        The menu bar has commands grouped into categories like projects, tools which has commands related to the fields.
    4.  Error List
        The error list shows the error, warnings and current state of code.
    5. Serach box:
        The search box makes it easy to search in visual studio.
    6.  Build Run and Debug:
        The build, Run and Debug options in the menu are used to work with code. Hotload option makes it possible to change code in runtime.

## Solution file
    The  solution file is a container of one more related projects.
## Default files 
    1.  Program.cs
        It is the console project that starts executing from entry point.
    2.  Dependancies file 
        It has the analyzers, frameworks and packages.
    3. EditorConfig
        The code lines are formated based on the changes in the EditorConfig file.

## TASK-2
     The generted program.cs file has the entry point of code with the main method in it.
     The code is build by configuring the build or the build is done on default configuration.
     The code is build and can be debugged by viewing output in console window.

## TASK-3
    Reference can be add by add refernce dialog box or directly adding reference to MSBuild by specifying the assembly name and not the path.
    NuGet Packages:
      Has reusable code that can be used in code.
      After installing a package, it can be used referenced in code with the using statement.

    Newtonsoft.Json package is installed from package manager.
    A simple program to write .NET objects as JSON is written and it is referenced by using keyword.
    A class weatherForecast is created with attributes, the objects is coverted into JSON by using the JsonSerializer.Serialize function.
       
## TASK-4
    BreakPoints :
        Breakpoints are used to pause the execution of code while debugging.
        When the program stops at the breakpoint, the variable values and call stack can be seen.
    Call Stack:
        Call stack has the order of the functions called.
    Exception Window:
        Selecting an exception from the exception to break the debugger execution whenever the exception is thrown.
    Immediate Window:
        Immediate Window is used to debug and evaluate expressions, print variable names.
        It evaluates expressions by building the current project.
    Command Window:
        It is used to execute commands directly into the visual studio IDE.
    Output Window:
        The status messages for different features are displayed in the command window.
    Error List:
        The error list displays the errors, warnings, messages and allows to navigate through them.

## TASK-5
    Navigation Tools:
    Go to definition:
        The Go to definition shows the source code definitions of a function, member or type.
    View Reference:
        The view refernces option enables to see the  code elements are referenced in the tool bar window.
    Go to Implementation:
        The Go to Implementation command takes to thr implementation of the base class or type. It shows the multiple implementation in the window.
    Go to Base:
        It takes to the base class from an inheritance chain.

    Code Refactorating:
        The code can be modified to make it easier to understand, maintain and extend without changing its behaviour.
        The Rename option enables to change the name of the variable at all occurance in a single time.

    IntelliSense:
        The IntelliSense is a code completion aid that helps to complete code snippets witha number of options.
        It has functions like List Members, sort, Parameter Info, Quik Info which show the information of the selected member or type.

    Features that helps in development:
        The word completion feature makes it easy to code by offering suggestions.
        The integrated version control feature makes it easy to commit, push, pull and switch between branches easily.
        The refactoring features like renaming variables and extracting methods makes the code more readable and strutured.
        The code tempelates nad snippets feature suggests common code pattern which helps in developing code.



