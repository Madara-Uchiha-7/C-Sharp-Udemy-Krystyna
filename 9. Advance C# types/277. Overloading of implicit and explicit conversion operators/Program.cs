///
/// We've learned about implicit and explicit conversion before, but let's see a quick reminder of what
/// they are.
/// 
/// Implicit conversion happens when we assign one type to another.
/// For example, an int to a decimal. 
int ten = 10;
decimal tenAsDecimal = ten;
/// So in a typical case, such code should not compile.
/// But this code does because the conversion operator is overloaded for the decimal type.
/// It defines what should happen if an integer is assigned to a decimal.
/// In this case, nothing special happens because a decimal is perfectly capable of storing the value of
/// ten.
/// 
/// What we see here is called the implicit conversion, because it doesn't require any extra syntax.
/// It is safe and lossless, as both those variables will represent exactly the same number.
/// It would not be the same for the opposite conversion.
/// 
decimal someDecimal = 20.01m;
int someInt = someDecimal;
/// The above code will not compile.
/// This is because the conversion from decimal to integer is not lossless.
/// 
/// The number 20.01 will have to be trimmed to a whole 20 so it can be stored in an integer.
/// Since this operation is not as safe as the one we saw before, we will have to perform the explicit
/// conversion here.
int someInt1 = (int)someDecimal;
/// This way we say we know about the risk of losing some data and we want to perform the conversion anyway.
/// 
/// 
/// It's quite a common use case that we want to overload the conversion operators in our custom types.
/// Let's consider the point again.
/// Let's say that our application is getting some points data from an external library and that those points
/// are delivered to us as tuples storing two integers.
/// We would like to be able to simply assign such a tuple to a variable of point type, thus performing
/// a conversion.
///
var tuple = Tuple.Create(10, 20);
Point point = tuple;

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

    // Here we specify that this will be the implicit conversion operator.
    // The target type will be Point: because we have written Point in "Point(Tuple<int, int> tuple)"
    // and
    // the source type will be a tuple of two ints :because we have written tuple in "(Tuple<int, int> tuple)"
    // If you change the word implicit to explicit 
    // then line : Point point = tuple;
    // will not compile.
    // If you use word explicit below then you will have to write :
    // Point point = (Point) tuple; instead of : Point point = tuple;
    // So, which of those(implicit and explicit) two operators should be used depends on the use case.
    // If the conversion is safe and lossless and has no chance of doing something unexpected, we can use
    // the implicit conversion.
    // This is our case, so we will keep the word implicit below.
    // If the conversion isn't safe and lossless,
    // so it can result in an exception or it will need to trim some data,
    // we should use the explicit conversion operator.
    public static implicit operator Point(Tuple<int, int> tuple) =>
        new Point(tuple.Item1, tuple.Item2);
}
