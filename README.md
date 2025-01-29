# C# Uncommon Bug: Understanding Reference Types and Unexpected Behavior

This repository demonstrates a common yet subtle bug in C# related to reference types.  When working with reference types (like classes), assigning one object to another doesn't create a copy; it creates a second reference to the same object.  Modifying the object through either reference will affect both.

## The Bug
The `bug.cs` file contains code that initializes a `MyClass` object. Another variable is assigned a reference to this object. When a property of the object is modified through the second variable, the change is reflected when accessing the property through the original variable, due to both referencing the same instance.

## The Solution
The `bugSolution.cs` file showcases how to create a deep copy using memberwise cloning and the `MemberwiseClone()` method to resolve this issue.  Deep copying creates a new instance of the object with the same values, but modifications to one copy will not affect the other. Note that for complex objects (containing other objects), memberwise cloning may not be sufficient, requiring custom deep-copy logic.