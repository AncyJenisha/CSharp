# String Manipulation Utility
A simple C# utility for performing various string manipulations on text files. This utility includes methods for formatting posts, extracting tags, searching text, analyzing text, comparing posts, parsing URLs, and concatenating titles.

## Introduction
The String Manipulation Utility provides a set of methods to perform various operations on text files, particularly those related to analyzing and manipulating the content. It is designed to make text processing tasks easier and more efficient.
 
```csharp

// Example: Formatting Posts
MethodCalls.CallFormatPost();

// Example: Extracting Tags
MethodCalls.CallExtractTags();

// Example: Searching Text
MethodCalls.CallSearchQuery();

// Example: Analyzing Text
MethodCalls.CallAnalyzeText();

// Example: Comparing Posts
MethodCalls.CallComparePosts();

// Example: Parsing URLs
MethodCalls.CallParseUrls();

// Example: Concatenating Titles
MethodCalls.CallConcatenateTitles();
 
```

There are different methods for each type of operation. 
These methods take care of reading files, processing content, and generating results.


## Structure

The project consists of the following components:

`Program.cs`: The entry point of the application, where you can choose the operation to perform.

 `MethodCalls.cs`: A utility class containing methods for each string manipulation operation. It reads files, processes content, and displays results.

 `PostFormater.cs`: A class that contains methods for various text manipulations, such as formatting posts, extracting tags, searching for text, analyzing text, comparing posts, parsing URLs, and concatenating titles.

 `EnumOfMethods.cs`: An enumeration that defines the available string manipulation operations.