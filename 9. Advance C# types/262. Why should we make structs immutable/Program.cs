
Point point = new Point(10, 20);

/// Lets say some programmer has decided to write the metohd to update the X value.
/// Like below. But now when user will use MoveToRightFromOneUnit(point).
/// It will not update the X for the Struct object point which is passed on the method.
/// Because copy of the object point will be passed to the 
/// method and that copy object's X will get updated.
/// If you want make it work, that is if you want the changes to happen on the object that is passed
/// and not the copy object that is getting passed then use the ref keyword. Like:
/// void MoveToRightFromOneUnit(ref Point point) and MoveToRightFromOneUnit(ref point).
/// You have to add this on both the places. In the method definition parameter and 
/// in the method call argument. But this becomes ugly and hard to read as code getting bigger.
/// So this is the reason to make disable the ability to modify strcuts altogether and make them
/// immutable. We can do this by changing the set; to init; for X and Y.
///  
void MoveToRightFromOneUnit(Point point)
{
    point.X++;
}

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
/// Many built in structs are immutable.
/// E.g. while using the DateTime struct, we can not modify its properties.
/// DateTime date = new DateTime(2023, 6, 7);
/// date.Day += 7; -> Not allowed
/// But sometimes it is better to update the Day by adding the 7.
/// We will learn this in the next section after the coding exercise.
/// 
