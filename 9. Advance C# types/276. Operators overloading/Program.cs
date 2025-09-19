///
/// We will learn how operator overloading works in C#.
/// We will overload the addition, equality and inequality operators.
/// We will also learn which operators can be overloaded and which cannot.
/// 
/// The important thing to understand about operators is that their behavior differs depending on what types
/// they are used with.
/// For example, adding two numbers with the addition operator will calculate the sum of numbers while
/// adding strings with the same operator will concatenate those strings.
/// 
/// When defining our own types, we would often like to provide a custom implementation for some operators.
/// Let's consider our Point struct.
/// 
/// Let's say we would like to define the operation of adding two points.
/// It should work by adding their x and y coordinates.
/// For example, adding those two points should give a new point with coordinates 3 and 9.
/// Point point2 = new Point(1, 5);
/// Point point3 = new Point(2, 4);
/// 
/// The simplest solution is to define the Add method in the point struct.
/// This will work, but it is a bit awkward to use.
/// It would be more convenient to perform the addition with the + operator.
/// It is, after all, the addition operator.
/// The compiler doesn't yet know how to add two points. To enable the addition of two objects of this type
/// we must overload the addition operator.
/// To overload an operator
/// we must basically create a special method.
/// First of all, it must be static.
/// Then we define the result of this operation.
/// In our case, adding two points results in creating a new point type.
/// Then we must add the "operator" keyword, followed by the operator itself.
/// Finally, we define the operands as the parameters of this method.
/// Remember, operands are the things the operator gets applied to.
/// In our case, the addition operator will be applied to two operands of the point type.
/// So we overloaded the addition operator for Point type.
/// This will work now:
/// Point point4 = point2 + point3;
/// 
/// Let's also overload the equality operator for this struct.
/// If we decide to overload the equality operator, we must do the same with the inequality
/// operator. Otherwise we will get the compilation error.
/// 
///

Point point2 = new Point(1, 5);
Point point3 = new Point(2, 4);

Point point4 = point2 + point3;

Console.WriteLine(point2 == point3);

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


///
/// We can overload most of the C# operators, but not all of them.
/// For example, we can't overload the lambda operator (=>), the member access operator (.) or the new operator (new)
/// or && or || and more.
/// Check:
/// It has the full list of operators that can be overloaded:
/// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading
/// 
/// There are two interesting operators.
/// Let's discuss them in the next lecture. 
///

