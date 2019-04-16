# Data-structures
Implementation of various data structures in C#, with unit tests for each data structure.

## Introduction
This repository represents some of the code I have written to gain a more robust understanding of common data structures in C#. I implemented many of these structures in C and C++ long ago, but pointers and reference objects work differently in C#, and I thought it would be beneficial to understand exactly how it could be done in this language. Please note that I wrote all of these implementations without looking at the C# standard libraries or other example code; they are the answer to a questionless assignment. As such, I do not mean for these implementations to be the best or comparable to the Microsoft's implementation. My goal is to implement the basic functionality of these structures and to provide unit tests for them. For any production use, please use the standard C# libraries.

## Requirements
- Visual Studio 2017 or newer

## Current Implementations
- ### Generic Singularly Linked List
   This implementation of a singularly linked list uses the following implemented classes and interfaces: `INode`, `ILinkedList`, `Node`, `LinkedList`. It also implements the `IEnumerable` class. This implementation implements standard linked list functionality including, `Find`, `InsertBeginning`, `InsertAfter`, etc. Since it is a generic class, it can be used as a linked list of any object type. To help facilitate this, it uses the `EqualityComparer<T>` generic class to check equality when needed.

## Usage
To run this project, clone the solution or use Git's "Open in Visual Studio" function to launch the solution in Visual Studio. The data structures are implemented in a C# Class Library project named `Data-Structures-Classes`. The unit tests for the data structures are implemented in a C# Unit Test project named `Data-Structures-Tests`. 

Since the data structures are implemented in a C# Class Library project, you cannot run them directly. However, you can execute the unit tests to see that everything functions as intended. The unit tests themselves and some basic knowledge of the data structures should give insight as to how they function.

## Liability
This repository is provided as is. I make no representations or warranties of any kind concerning the legality, safety, suitability, lack of viruses, inaccuracies, typographical errors, or other harmful components of this repository. There are inherent dangers in the use of any software, and you are solely responsible for determining whether this software is compatible with your equipment and other software installed on your equipment. You are also solely responsible for the protection of your equipment and backup of your data, and I will not be liable for any damages you may suffer in connection with using, modifying, or distributing this software. This software was written for educational purposes only.
