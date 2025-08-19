///
/// Structs always have the parameterless constructor.
/// If a class does not have the defition of the parameterless constructor then it will create on its
/// own, so creating the object of class {Person person = new Person()} will not give the error. 
/// But if you create a parameterised constructor in your class then create the object of the class
/// without passing the values to those parameters then it will throw the error. 
/// So, line : Person person = new Person() -> Will give the error.
/// This is not the case with the Structs.
/// So even if you create the parameterised constructor without the parameterless constructor in the
/// struct, the StructName structVarName = new StructName(); will sill work.
/// I think this is because it can not be null so all the values will get set to default I guess.
/// Before C# 10 there was no option to add the parameterless constructor to the struct
/// There are also some historical differences, which I would like to mention even 
/// if they are no longer the case - just in case you worked with some older C# version.
/// Before C# 11, all fields of a struct must have been initialized in the constructor. 
/// So if this constructor did not initialize both X and Y in C# 10 or older, we would get a compilation 
/// error. Since C# 11, it is no longer the case, and if a field is not initialized, it is set to the 
/// default value, similarly as it happens for classes.
/// Before C# 10, structs could not have a parameterless constructor declared. 
/// Such a code like this would simply not compile. Starting with C# 11, 
/// such a constructor can be declared, but it must be public. For classes, it can be private. 
/// 
/// Structs can not have the finalizers. -> Point 1
/// Because strcuts are copied on assignment and when passed as arguments to method.
/// So, lets say we are closing the connection of the database 
/// using the finalizer and we passed this struct to method.
/// Then this will create the copy of this struct. Let us say this method closes the connection of the 
/// database using the copy struct's finalizer. But there is a possibility that 
/// original struct object needs this connection. So to avoid such things, finalizer it not allowed.
/// For classes this will not be a case because they are not copied when passed as arguments.
/// 
/// Struct can not contain a cycle in its definition. -> Point 2
/// It means struct can not have a property of the same type.
/// Reason, struct uses stacks, which don't have the big size. So, this "ClosetPoint" may contain
/// another struct inside it which may contain another. So,  
/// struct can not contain a cycle in its definition. While this is allowed in the classes becasue 
/// they use much larger heap.
/// The evolution of structs is described in detail in this article: 
/// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct
///

struct Point
{
    // Point 2 Reference:-
    public Point ClosetPoint { get; }

    public int X { get; init; }
    public int Y { get; init; }

    // Point 1 Reference :-
    // This below is finalizer which is not allowed.
    ~Point() 
    {
        Dispose();
    }
}