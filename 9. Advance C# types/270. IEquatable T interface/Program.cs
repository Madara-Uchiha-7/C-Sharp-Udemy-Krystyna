///
/// We will learn what the IEquatable interface is and why we should bother implementing it.
/// We will also understand how it is different from the IComparable interface.
/// We will see what happens if there are two methods with the same name in a type which could
/// both be used with a given argument.
/// 
/// Let's consider what happens when we check the equality of two points.
/// Check line :
/// point3.Equals(point2);
/// The Original signature of Equals method:
/// public bool Equals(object? obj)
/// 
/// The Equals method taking an object as a parameter, is called. Since the parameter is an object.
/// the Point given here(obj from "object? obj") must be boxed.
/// The boxing has the performence issues.
/// 
/// Then the Equals method checks
/// if this object is indeed a point and it is so it gets unboxed.
/// Unboxing also has the performence issue.
/// 
/// Then we compare the fields and properties of those two points one by one using refraction.
/// Refraction also has the performence issue.
/// 
/// The performance might be negatively impacted even if we override
/// the Equals method so it doesn't use reflection.
/// It won't save us from unnecessary boxing and unboxing, but there is something that can do it.
/// 
/// Suppose we add a new overload of the Equals method in Point type, which explicitly takes a point as a parameter.
/*
public bool Equals(Point other)
{
    return X == other.X && Y == other.Y;
}
*/
/// In that case, this Equals method which takes an object will not have to be called.
/// The specialized method will be.
/// And since it operates on a Point parameter, not an object parameter
/// no boxing and unboxing will need to happen.
/// This, by the way, shows us something interesting.
/// If the runtime sees two methods with the same name in a type, and if both could be used with a given
/// argument, then it chooses the more specialized one.
/// So from those two methods, this one will be used with a Point argument because this type is more specific.
/// Let's add a new Equals method to the Point struct.
/// 
/// Of course, if we compare a point and an object of another type, the method taking a System.Object
/// parameter will be used.
/// 
/// Now those methods are a bit duplicated. In the method which takes the object as the parameter,
/// instead of comparing X and Y, we can simply call the new Equals method.
// I.e. We can make:
/*
public override bool Equals(object? obj)
{
    return obj is Point point && point.X == X && point.Y == Y;
}

To:
public override bool Equals(object? obj)
{
    return obj is Point point && Equals(point);
}

This is already a big improvement, but it can still be better.

Let's consider the Contains method again.
Method definition of the contains method.
In a simplified version, it looks like this.:

public static bool Contains<T> (
    this IEnumerable<T> collection,
    T itemToBeChecked)
{
    foreach (var item in collection)
    {
        if (item.Equals(itemToBeChecked))
        {
            return true;
        }
    }
    return false;
}

It iterates the collection and for each item it compares it with the given argument.
If they are equal, this method returns true.
But this method is generic and it doesn't know what T is.
It can be anything.
So the only methods it can call on T are the ones present in the System.Object type.
It means this Equals method will be the one taking an object parameter.
If it is overridden, the overridden version will be called because that's how polymorphism works.
But the overridden method still needs to box and unbox the struct it takes as an argument.
It would be great if we could somehow tell this method Hey, there is another version of the Equals
method in this type.
Well, actually, we can do that.
The Contains method is smarter than what we see here.
It checks if the T type implements the IEquatable of T interface, which contains the method we just
created: the equals method taking T, in our case a Point, as a parameter.
If T implements this interface, the contains method will use the Equals method coming from this interface
instead the one taking an object.
Thanks to this, no boxing will need to happen. To benefit from this improvement
all we have to do is to add the declaration that the point struct implements the IEquatable of point
interface.
Lets implement it by adding : IEquatable<Point>
We have already added the : public bool Equals(Point other)
So no need to implement the method from IEquatable.
The Equals method we added here is just the Equals method this interface needs.
Now, even if this struct is used in huge collections, the performance should remain good.

A quick comment before we wrap up.
Please be aware that IEquatable of T is different from IComparable of T. The first one checks if two
objects are equal and returns bool, the other one checks in what order they should appear if sorted
and it returns an integer which usually is -1,0 or 1.
*/
/// 
/// Our struct has gotton big now.
/// If you think you will always have to do all of this when defining structs, I have good news.
/// Soon we will learn about record structs which have all those methods out of the box. With record
/// structs the definition of a struct like this would take a single line of code.
/// 
///
Point point2 = new Point(10, 20);
Point point3 = new Point(30, 40);
point3.Equals(point2);
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

    public override bool Equals(object? obj)
    {
        return obj is Point point && point.X == X && point.Y == Y;
    }
    public bool Equals(Point other)
    {
        return X == other.X && Y == other.Y;
    }
}