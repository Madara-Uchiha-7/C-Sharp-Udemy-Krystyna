///
/// Person class example:
/// Currently it uses the default reference-based GetHashCode method.
/// The hash codes of all those people are different since they all have different references.
/// 
/// But the Equals method in the Person class considers two persons equal if their IDs are the same.
/// So the GetHashCode method should also only use ID.
/// It means those two people should have the same hash codes since their ideas are the same.
/// i.e.Now "martin" and "sameAsMartin" should have the same hash codes since their ideas are the same.
/// Now once GetHashCode() is overriden then we will get the same hash code for:
/// var martin = new Person("Martin", 6);
/// var sameAsMartin = new Person("Martin", 6);
///


var martin = new Person("Martin", 6);
var sameAsMartin = new Person("Martin", 6);

Console.WriteLine(martin.GetHashCode());
Console.WriteLine(sameAsMartin.GetHashCode());
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
        return obj is Person other && Id == other.Id;
    }

    public override int GetHashCode()
    {
        // We don't even need the HashCode.Combine method here since the ID is an integer.
        // So a perfect hash code by itself.
        return Id;
    }
}

/// We will revisit hash codes later in the course when we learn how dictionaries work under the hood.