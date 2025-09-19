///
/// We will take a closer look at the equality operator and we will understand how its behaviour
/// differs for value and reference types.
/// 
/// First, let's understand the default behavior for this operator.
///
/// For reference types:
/// It checks the equality of references.
/// So it behaves the same as the basic version of the Equals method. 
/// 
/// For value types:
/// Well, it is not supported.
/// This might be surprising since we used it a lot to check the equality of a value types, for example
/// integers.
/// E.g.
/// In last lecture you have two variables:
/// point2 and point3.
/// If you do point2 == point 3 
/// then 
/// code will not compile.
/// 
/// So how can it work for integers which are also value types?
/// E.g. 1 == 1
/// 
/// As it turns out, in C#, some operators may be overloaded.
/// Overloading an operator means defining its behavior in a type. Only
/// if we overload the equality operator, can we use it for structs. If we want
/// we can also overload it for reference types so it does something other than simply checking if the references
/// are equal.
/// 
/// This leads to an interesting outcome.
/// Since the Equals method can be overridden and the equality operator can be overloaded, there is no
/// simple answer to the question of how they behave and what the difference between them is.
/// 
/// For value types, it's all simple because they only support value-based equality,
/// for the simple reason that they don't have references. But for reference types it gets a bit tricky.
/// Suppose you want your reference type to support value-based equality.
/// In that case, you should both override the equals method and overload the equality operator.
/// If you want to support reference based equality.
/// You can just not do anything since this is the default for reference types, both when using the Equals
/// method and the equality operator.
/// 
/// And if for some reason you want to support both, then the conventional solution is to leave the equality
/// operator unchanged.
/// So it compares objects by reference, and then override the Equals method. So it compares values.
/// 
/// Just remember not to trust this convention too much since, as we said, the behavior of the Equals
/// method and the equality operator can be customized.
/// 
/// 
/// 
/// 
///