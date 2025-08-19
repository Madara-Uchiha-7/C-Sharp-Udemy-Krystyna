///
/// The fundamental difference between the classes and structs is that classes are the 
/// reference types and structs are value type. By the value type we mean they have a value type semantics.
/// If a type has a value semantics, the only way to modify the value of a variable of this type is through
/// the variable itself.
/// Value sematics gurentee that the values stored in the variables are independant.
/// For e.g. when a struct variable is assigned to another variable of this type, the whole struct will 
/// be copied. A variable of a struct type holds the struct value itself, not a reference to the object stored
/// on the heap. For structs there is not reference at all.
///

// Lets define the simple struct representing a point in the Cartisian coordinate system.

Point pointOne= new Point(10 ,20);
Point pointTwo = pointOne;

pointTwo.Y = 100; // This will make pointTwo.Y = 100 not pointOne.Y even though the pointTwo points to pointOne.

Console.WriteLine("Point 1 is: " + pointOne);
Console.WriteLine("Point 2 is: " + pointTwo);


struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // We are overriding the ToString() method from the system object type.
    // As all types in ther C#, the structs are also indirectly derived from the base type Object.
    // Struct extends the System.ValueType which is derived from System.Object class. 
    public override string ToString() => $"X: {X}, Y: {Y}";
}

// Same as classes the Structs cna have the fields, properties and constructors.
// They can also have the methods.

///
/// In most cases, struct variables declared locally in methods are stored on the stack.
/// So it means that Structs should not be too large. Because the stack is quit a small piece of
/// memory. Also, since the structs are copied, each time they are assigned to one another or passed as a 
/// parameter, making them large would be problematic because big objects can badly affect the performance.
/// In the section of generic types we learned about the constraints. As it turns out we can limit the 
/// types used as some generic type to only reference types or only value types.
/// We must use the struct constraint if we only want the value types. E.g. below:
///
//void SomeMethod<T>(T param)  where T : struct
//{
    // Now this method will only accept the value types.
//}
// SomeMethod(5); // Works :: SomeMethod(new Person()); // Fails because the Person is the class.
// If you do "where T : class", then passing 5 will not work and passing new Person will work.
///
/// 
///