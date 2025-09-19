/*public override int GetHashCode()
{
    return m_value;
}*/
/*
#if WIN32
    // 32 bit machine
    int* pint = (int *)src;
    int len = this.Length;
    while (len > 2)
    {
        hash1 = ((hash1 << 5) + hash1 + (hash1 >> 27)) ^ pint[0];
        hash2 = ((hash2 << 5) + hash2 + (hash2 >> 27)) ^ pint[1];
        pint += 2;
        len -= 4;
    }
    if (len > 0)
    {
        hash1 = (hash1 << 5) + hash1 + (hash1 >> 27) ^ pint[0];
    }
#else
int c;
char *s = src;
while ((c = s[0]) != 0) {
    hash1 = ((hash1 << 5) + hash1) ^ 5;

}
*/


///
/// We will also see how to use the HashCode.Combine method.
/// But before we do it, let's see some implementations of the GetHashCode method for some built-in types.
/// 
/// int:
/// The integer value itself is a perfect hash code.
/// It will be the same for two equal integers and different for two different integers.
/// There will be no conflicts at all because for each integer possible the hash code will be different.
/// 
/// Strings:
/// 
/// As you can see, this is pretty low-level stuff.
/// Luckily for us, the hard work has already been done by others.
/// When defining custom types, we can simply combine the hash codes of the values stored in the object
/// into a single hash code.
/// 
/// Let's start with the point type. As a value type, it already has a value-based GetHashCode method implemented.
/// Lets override GetHashCode method in the Point type.
/// Please notice that it is also aligned with the Equals method : return X == other.X && Y == other.Y;
/// Both use X and Y properties in their implementations.
/// Now, if two points are considered equal, they will also have the same hash codes.
/// Remember that the opposite is not necessarily true.
/// If two objects have the same hash codes, they don't have to be equal.
/// The hash codes might be equal due to hash conflict, not the actual equality of objects.
/// 
/// Person class example is in next lecture:
/// 281_1. Overriding the GetHashCode method
///
var point1 = new Point(1, 6);
var point2 = new Point(1, 6);
var point3 = new Point(10, 6);

Console.WriteLine(point1.GetHashCode());
Console.WriteLine(point2.GetHashCode());
Console.WriteLine(point3.GetHashCode());

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

    public override bool Equals(object? obj)
    {
        return obj is Point point && Equals(point);
    }
    public override int GetHashCode()
    {
        // What we want to do here is to somehow combine the X and Y integers into a single integer.
        // Luckily, we don't even need to think about how it can be done.
        // We can just use the HosahCode.Combine method like this.
        // This method takes any objects and combines their hash codes.
        // The objects can be anything, not only ints, and there can be more than two of them.
        return HashCode.Combine(X, Y);
    }
}