Person john = new Person("John", 1);
Person theSameAsJohn = new Person("John", 1);
Person maria = new Person("Maria", 2);

Console.WriteLine(john.Equals(theSameAsJohn)); // True
Console.WriteLine(john.Equals(maria)); // False
Console.WriteLine(john.Equals(null)); // False
Console.ReadKey();
class Person
{
    public string Name { get; set; }
    public int Id { get; set; }
    public Person(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public override bool Equals(object? obj)
    {
        // "obj is Person other" returns false if not Person object
        // If true then "other" will represent the object case to Person type.
        return obj is Person other && Id == other.Id && Name == other.Name;
    }
}

/// 
/// There is another method GetHashCode() in Object class which we can override.
/// When we override Equals() then it is recommended that we override GetHashCode()
/// also. We will learn about this GetHashCode() later.
///