///
/// We will learn what the default implementation of the GetHashCode method is for value
/// and reference types.
/// 
/// For reference types:
/// It is calculated using the reference itself.
/// 
/// For value types:
/// It is calculated by combining their values.
/// 
/// Let's see what it means in practice.
/// We will start with reference types.
/// Check : 1. Reference type
/// 
/// The dictionary distinguishes the keys it stores by calculating their hash codes.
/// For a dictionary, if two objects have different hash codes, they are considered different keys.
/// Here we created a person object martin and we put it as the key in the dictionary with five as its corresponding
/// value.
/// 
/// There is one more object of Person class "sameAsMartin".
/// "sameAsMartin" has same values as "martin".
/// 
/// dictionary[sameAsMartin] = 10; Will work and will not throw the error.
/// 
/// To understand it, we must remember how the default implementation of the GetHashCode method works for
/// reference types.
/// It bases on the value of the reference itself.
/// So martin object and sameAsMartin object have different hash codes even if they store the same values because
/// their references are different.
/// So from the dictionary's point of view, they are different objects representing different keys.
/// 
/// But this is not the case for structs.
/// The default implementation of the GetHashCode method for value types combines the values of their fields
/// and properties.
/// 
/// dictionaryStruct[point2] = 10; 
/// will override the value 5 of 
/// dictionaryStruct[point1] = 5;
/// Because both point to the same thing.
///

// 1. Reference type:
var dictionary = new Dictionary<Person, int>();

var martin = new Person("Martin", 6);
dictionary[martin] = 5;

var sameAsMartin = new Person("Martin", 6);
dictionary[sameAsMartin] = 10;

Console.WriteLine(dictionary[martin] + " : " + martin.GetHashCode());
Console.WriteLine(dictionary[sameAsMartin] + " : " + sameAsMartin.GetHashCode());

// 2. Struct type:

var dictionaryStruct = new Dictionary<Point, int>();

var point1 = new Point(1, 6);
dictionaryStruct[point1] = 5;

var point2 = new Point(1, 6);
dictionaryStruct[point2] = 10;

Console.WriteLine(dictionaryStruct[point1] + " : " + point1.GetHashCode());
Console.WriteLine(dictionaryStruct[point2] + " : " + point2.GetHashCode());


Console.ReadKey();
readonly struct Point : IEquatable<Point>
{
    public int X { get; init; }
    public int Y { get; init; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString() => $"X: {X}, Y: {Y}";
    public bool Equals(Point other)
    {
        return X == other.X && Y == other.Y;
    }

    public static Point operator +(Point a, Point b) =>
        new Point(a.X + b.X, a.Y + b.Y);
    public static bool operator ==(Point a, Point b) =>
        a.Equals(b);
    public static bool operator !=(Point a, Point b) =>
        !a.Equals(b);
}
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
        return obj is Person other && Id == other.Id && Name == other.Name;
    }
}