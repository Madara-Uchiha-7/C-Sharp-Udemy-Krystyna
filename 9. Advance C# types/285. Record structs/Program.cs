using System.Drawing;

///
/// We will learn about record structs. Starting with C# 10
/// record structs were introduced.
/// 
/// 
/// They are similar to records and they also provide efficient implementations of the Equals, GetHashCode
/// and ToString methods as well as equality operators.
/// But there are some significant differences between records and record structs.
/// 
/// Record structs are value types.
/// Positional record structs are mutable by default.
/// 
/// Records are reference types.
/// Positional record are immutable by default.
///
/// 
/// Lets see Positional record struct.
var rectangle = new Rectangle(10, 20);
// As you can see, the properties of this record struct are settable.
// If we want this record struct to be immutable
// we can add the readonly keyword here.
// It will become: public readonly record struct Rectangle(int A, int B); 
// If you do then below line will not work. This record struct is now immutable.
rectangle.A = 20;
Console.ReadKey();
public record struct Rectangle(int A, int B);
///
/// 
/// When deciding whether to use records or record structs, we should take the same things into consideration
/// as when deciding whether to use classes or structs.
/// 
/// If the type is small and simple and we want value type semantics, meaning passing parameters by value
/// or assignment that creates a copy, we should go for record structs.
/// 
/// 
/// Records and record structs are types introduced in C# 9 and 10.
/// They are mostly used to define simple types representing data.
/// They support value-based equality and hash code calculation.
/// They also make it very easy to create immutable types.
/// 
///