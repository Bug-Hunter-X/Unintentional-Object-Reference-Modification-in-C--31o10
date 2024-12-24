# Unintentional Object Reference Modification in C#

This repository demonstrates a subtle yet common error in C# programming: unintentional modification of objects due to shared references.  The `bug.cs` file contains code that exhibits this problem.  The `bugSolution.cs` file provides a corrected version.

**Problem:** When dealing with reference types (classes, arrays, etc.), assigning one variable to another doesn't create a copy of the object. Instead, both variables point to the same object in memory.  Modifying the object through one variable will reflect in changes seen through the other variable.

**Solution:** To avoid this, create a deep copy of the object when you need independent copies.  Various techniques can achieve this, depending on the object's complexity.