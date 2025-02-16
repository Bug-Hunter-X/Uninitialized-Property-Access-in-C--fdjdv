# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a class property before it has been assigned a value.  The `bug.cs` file shows the erroneous code.  The solution, shown in `bugSolution.cs`, correctly initializes the property before use.

This is a subtle bug that can be hard to spot. It can cause unexpected results or runtime exceptions depending on how the property is used.