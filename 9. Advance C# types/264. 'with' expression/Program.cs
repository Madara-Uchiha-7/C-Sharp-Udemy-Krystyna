///
/// Use "with" expression to perform non-destructive mutation of structs.
/// Lets say we want to move "point" one unit to right.
/// We can not modify the X property due to init-only. Look how we have used "with".
///

Point point = new Point(10, 20);
Point pointMoved = point with { X = 11 };
// We can also write { X = 11 } to { X = point.X + 1 }
// We can also set more properties like : { X = 11, X = 12 };


/// --- Point 1 reference:
/// If you still want to avoid var but keep using anonymous types, you can’t directly 
/// do it because anonymous types don't have an explicit type name.
var pet = new { Name = "Chinmay", Type = "Fish" };
var asBoka = new { Name = "Boka" };
Console.ReadKey();

struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString() => $"X: {X}, Y: {Y}";
}

///
/// Properties we set using "with" expression must be public and they can not be get only.
/// So, init is necessary here. So it works with init and set.
/// Thie "with" expression does not work for the classes. 
/// This expression can be used with structs, records and record structs.
/// We will learn about them later.
/// Intrestingly, the "with" expression also works for anonymous objects. Since they are immutable
/// we can bot modify them in any other way than non-destructive mutation.
/// E:g: Point 1
///