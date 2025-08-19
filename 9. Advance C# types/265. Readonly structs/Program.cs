///
/// How to enforce the immutablility of a struct.
/// We can do manually by making all the fields readonly and properties get only or init only.
/// But it is easy to forget about some field/property (no compiler warning). Also compiler does not
/// give the error in such case saying all the fields or properties should be immutable, because we are 
/// making them immutable manually.
/// If new dev comes to project, he may not know that we want the struct immutable and can add 
/// mutable fields or properties.
/// So, safer way is by adding readonly keyword to struct.
/// Now we will get the error if we add a code in a struct that is supposed to be immuable but
/// is not.
///

readonly struct Point
{
    private int _z; // --> Error because this is not readonly (Make it: private readonly int _z;)
    public int X { get; set; } // --> Gives error because of set
    public int Y { get; init; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString() => $"X: {X}, Y: {Y}";
}