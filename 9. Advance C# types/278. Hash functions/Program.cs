
using System.Drawing;

///
/// We will learn what hash functions are and how they relate to the GetHashCode method.
/// We will see what the characteristics of a good hash functions are.
/// Also, we will understand what hash conflicts are and why they are inevitable.
///
/// We have one more method from the System.Object type to learn about: the GetHashCode method.
/// 

Console.WriteLine(123.GetHashCode()); // O/p : 123
Console.WriteLine("123".GetHashCode()); // O/p : 1683284193

/// For now, the output values look enigmatic, but we will understand them better soon.
/// What we need to know now is this:
/// The GetHashCode method is the hash function implementation for C# objects.
/// But what is a hash function?
/// Well, a hash function is a one way cryptographic algorithm that maps an input of any size to an output
/// of a fixed length of bits.

/// Let's break it down.
/// First, let's understand what the result of this hash function is.
/// In C# it's an integer.
/// In simple terms, the hash produced by the hash function is a number calculated for some object from
/// its components.
/// 
/// In C#, those components are fields and properties of an object.
/// Let's see an example.
/// Person :
/// firstName : John
/// lastName  : Smith
/// born      : 1987
/// 
/// Here we have some person object and the hash calculated for this object is : 19873142
/// We will take a closer look at how the hash is actually calculated a bit later.
/// 
/// For now, let's just say that it's a function of the values of fields and properties belonging to the
/// object.
/// 
/// In this case, we could, for example, associate each letter with a digit, which would allow us to
/// translate the words "John" and "Smith" into integers.
/// 
/// Then we would somehow combine those integers with the integer representing the year of birth, and as
/// a result we would have the hash code of this person.
/// 
/// How this combination would work depends on the implementation.
/// The naive implementation could be anything, like adding or multiplying numbers.
/// 
/// But in practice, hash code components are combined using some low-level mathematical operations.
/// Luckily they are already implemented in C# and we don't need to implement them ourselves.
/// 
/// According to what we said, if we created another object of the person class with the name John, last
/// name Smith and Year of Birth 1987, its hash should be the same.
/// On the other hand, if this other object would have, for example, a different year of birth,
/// its hash would be different. If we calculate the hash for the second time, the result should be the
/// same as the first time. Assuming the object was not modified.
/// 
/// If we have two objects that are different instances, but we consider them equal, the hash code of
/// both of them should be the same.
/// 
/// For example, let's say we have two points, both having x equal to ten and Y equal to 20.
/// Even if they are two different instances, we consider them equal, so their hash codes should be the
/// same.
/// 
/// This, by the way, is the reason to override the Equals method together with the GetHashCode method.
/// Their implementations should be aligned.
/// 
/// 
/// For example, if we only compare the IDs of people in the equals method, it means the ID should also
/// be the only component used in the hash code calculation.
/*public override bool Equals(object? obj)
{
    return obj is Person other && Id == other.Id;
}
public override int GetHashCode()
{
    return Id;
}*/
/// We will investigate it further later in the course.
/// But what is the use for hash codes?
/// Well, their main use is that they work as keys in hashed collections.
/// For now, we learned about one hashed collection, the dictionary.
/// Another commonly used hash collection is hash set, which we will learn about in the section about collections.
/// Generally speaking, hash collections are characterized by very good performance, especially when retrieving
/// items stored in them or checking if some object exists in them.
/// For now, let's focus on the dictionaries.
/// As you know, each value in a dictionary is stored under a key.
/// The key can be any object, even a complex one, like a person or a point.
/// But the dictionary needs to be able to translate this key to an integer.
/// And that's exactly where the GetHashCode method comes in handy.
/// The bottom line here is this: We must be able to translate complex objects into simple integers to make
/// them work in hashed collections.
/// And that's exactly the job of the hash function, in C #implemented by the GetHashCode method.
/// 
/// An important trait of hash functions is that they should uniformly distribute their values.
/// This means if I call the GetHashCode method on 100,000 different objects of the point type, I should
/// get very little or no duplicated hash codes.
/// 
/// But it is possible to have duplicated hash codes.
/// This situation is called hash code conflict and it's perfectly normal.
/// Many people consider hash codes to be identifiers of objects and think that two different objects of
/// the same type can't have the same hash codes.
/// If this was true, we wouldn't need the Equals method because we could just check the equality of objects
/// by comparing their hash codes.
/// But this is not true, and it cannot be.
/// 
/// Proof:
/// Let's again consider a point type.
/// struct Point { int x; int y;}
/// It contains two fields: X and Y.
/// Both x and Y are integers, so each can have a value between the minimal and maximal value of int.
/// For simplicity, let's say that the minimum value of the integer is -2 billion and the maximal is plus
/// 2 billion.
/// This means we can have 4 billion different x coordinates and 4 billion different y coordinates, which
/// in total gives 4 billion times 4 billion different points, which is 16 quintillion.
/// 
/// On the other hand, the hash code itself is an integer, so it can only have 4 billion different values,
/// which is much, much fewer than different points.
/// So when creating different points, we will sooner or later simply run out of different hash codes.
/// It is sometimes referred as the balls into bins problem.
/// If we have more balls than bins and each ball is stored in some bin, it must mean there is more than
/// one ball in some bins.
///
/// 
/// 
/// 

/*Point point2 = new Point(1, 5);
Point point3 = new Point(2, 4);

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
*/