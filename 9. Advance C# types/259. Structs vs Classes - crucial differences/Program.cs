/// 
/// Not all types in C# can be assigned null
/// Only reference types can be assigned to be null.
/// Value types (struct) can not.
/// So, StructName structVairableName = null; // this is not valid.
/// null is the short name for null reference.
/// So, when a reference type variable stores null, it basically means the variable
/// does not store a reference to any existing object.
/// The fact that structs are not nullable also means that if a struct is a member 
/// in some type, its default value won't be null. 
/// You can check what value to stores in below example.
/// We will create the struct object in the class and we will check the class object 
/// in the quick watch by debugging the code. 
///


// Add a breakpoint here to Console.ReadLine() and see what comes in 
// the person reference. Go to quickwatch and check what is stored in the _favouritePoint.
// You will see {X:0, Y:0}. All the fields of the struct will be set to the default value.
// If you check the reference _favouritePerson, you will see it as null.
Person person = new Person();
Console.ReadKey();
struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString() => $"X: {X}, Y: {Y}";
}

class Person
{
    // We have created the Point struct objcet without any value.
    // Lets see what is stored in it when we create the person object on top.
    private Point _favouritePoint; 
    private Person _favouritePerson;

    public int Id { get; init; }
    public string Name { get; init; }
}

///
/// All structs are sealed, it means they can not be inherited.
/// struct TestStruct : Point -> this will give you the error.
/// Also it is not possible to make a struct derived from a class.
/// struct TestStruct : Person -> this will also give you the error.
/// Since nothing can inherit from a struct, there is no point in having virtual or
/// abstract members in them because they could never be overriden by the derived type.
/// Thats why struct can not have the virtual or abstract members.
/// Structs can still implement the interface though.
/// Keep in mind that interfaces are reference types. So if a struct is passed to a method
/// expecting a parameter of an interface type, this struct will have to be boxed.
/// 
