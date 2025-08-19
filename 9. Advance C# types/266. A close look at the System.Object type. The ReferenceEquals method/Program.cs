///
/// We will see what methods we can call on any object in C#.
/// Also we will see about ReferenceEquals() from the System.Object type.
/// Knowing this method will help us understand better how equality checking works for objects.
/// This section is focused on advance C# types like structs, records or ValueTuple.
/// Since every type in C# derives from System.Object, those methods are present in every object we use.
/// Lets see: 
///

object obj = new object();

/// ToString() : Converts an object into a string. Unless overriden it returns
/// type's full name, including the namespace. It is overriden for many built in types.
/// Thanks to that numbers, bools, Date times etc. can easily be expressed as string.
/// 
string abtObj = obj.ToString();

/// GetType() : It returns the "Type(class called Type)" object that carries the information about 
/// the object's type. For, e.g. its name, base type, implemented interfaces etc.
/// The GetType() method is the core component of the reflection mechanism. 
/// 
Type type = obj.GetType();

/// Equals(): It is a virtual method used for checking object equality. We will learn all about 
/// it in the next lecture. 
/// 

/// ReferenceEquals() : It checks if the references of the 2 objects are same.
/// i.e. if 2 objects are located at the same address in memory.
/// 
Person john = new Person("John", 1);
Person sameAsJohn = new Person("John", 1);
Person againJohn = john;
// Will give false. Because it does not check the values, it will only check the equality of 
// references. 
Console.WriteLine("Are references equal? : " + object.ReferenceEquals(john, sameAsJohn)); 
// Below will return true. On the assignment of reference type, reference is copied.
Console.WriteLine("Are references equal? : " + object.ReferenceEquals(john, againJohn));  
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
/// ReferenceEquals() will return false for value types. Because any value passed to this 
/// method will be boxed. It means that they will be packed in seperate objects and thus will have
/// different references.
/// You can try doing
/// Console.WriteLine(object.ReferenceEquals(1, 1)); This will return false. 
/// because it is a value type. Even Visual Studio will warn you and tell you that 
/// passing value type does not make sense.
/// 
/// If both the reference objects are null then ReferenceEquals() will retuen true.
/// Console.WriteLine(object.ReferenceEquals(null, null)); This will return true.
/// 
/// ReferenceEquals() is a static method in the System.Object type and as a static method it 
/// can not be overriden. We can override the Equals() method though.
///
