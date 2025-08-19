///
/// It comes under System.Object type.
/// Definition:
/// public virtual bool Equals(object? obj)
/// 
/// It takes another object and tells us whether it is equal to the current object or not.
/// Until now we checked the equality of objects using Equality operator i.e. ==
/// We will also see the relation between Equals() and ==
///

Console.WriteLine("1 Equals(1) : " + 1.Equals(1)); // True
Console.WriteLine("1 Equals(2) : " + 1.Equals(2)); // False
Console.WriteLine("1 Equals(null) : " + 1.Equals(null)); // False
Console.WriteLine("'abc' Equals('abc') : " + "abc".Equals("abc")); // True


Person john = new Person("John", 1);
Person theSameAsJohn = new Person("John", 1);
Person maria = new Person("Maria", 2);

Console.WriteLine(john.Equals(theSameAsJohn)); // False, Because both objects are diff
Console.WriteLine(john.Equals(maria)); // False
Console.WriteLine(john.Equals(null)); // False

Console.ReadKey();
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

///
/// For line : Console.WriteLine(john.Equals(theSameAsJohn)); 
/// The default implementation for classes for Equals method will check the 
/// reference of classes. Under the hood it uses ReferenceEquals() method. 
/// This Equals() is virtual means we can override it. It is overridden for many 
/// built-in types, including System.Value type. The base class for all the Value types.
/// Thats why that numeric and string comparison worked.
/// If you use Equals() with structs then it will compare the values not the reference,
/// and will return true if values are same in both the struct objcets which are 
/// getting compared. This is because struct is value type.
/// 