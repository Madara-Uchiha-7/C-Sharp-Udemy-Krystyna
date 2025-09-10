// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

/*
The first family of types is value types.
So types with value semantics.
All value types are derived from System.ValueType, which as all types in C# is derived from System.Object.
Simple built-in types like int, decimal, DateTime, bool are all value types.
Earlier in the course we mentioned structs, but we did not yet discuss them in detail.
Structs are conceptually similar to classes and they can also have fields, methods etc.
The main difference is that structs, unlike classes, are value types.
Many built-in types, for example, datetime or decimal are structs.

The second family of types is reference types.
All reference types are derived from System.Object.
All classes are reference types, both the user-defined ones and the built-in classes like List, object, array etc.
The fundamental difference between value and reference types is that a reference type variable only
holds a reference to the actual data, while the value type variable holds the actual data.
Remember, you can think of a reference as an address pointing to where the object is located in memory.

Usually, when we create a local variable in a method and this variable is a value type, it gets stored on stack.
On the other hand, if this variable is a reference type like the John variable of the type Person we
created before, only the reference will be stored on the stack and it will point to the actual object that is stored on the heap.

People often say that all value types are stored on the stack and all reference types are stored on
But this is a dangerous oversimplification.
So the reference type values are always stored on the heap, while the references themselves behave
like value types, so they can either be stored on the stack or on the heap.


Even if you pass value type to the function as the argument, its copy will be created in the parameter so
that original varibale will not change.
*/