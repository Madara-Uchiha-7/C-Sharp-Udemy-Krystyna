
/// <summary>
/// As we know that Equals will check the fields and properties of the structs 
/// and if they are same as the other struct object then it will return true.
/// But depending on the bussiness logic we can change it. For e.g. if struct 
/// has unique id then we do not want it to be compared with other struct ids.
/// The most common reason to override the Equals() for struct is performance.
/// This is because in most cases the Equals method for struct uses reflection 
/// under the hood. Reflection is used to read all fields and properties of a struct,
/// access their values and compare them one by one.
/// But reflection is slow. 
/// So if we except the Equals method to be called frequently on strcut, then we should
/// override it. Equals() method is used often than you can think off.
/// Uses cases of Equals in struct:
/// 1. Remember the Contains method from LINQ. It checks if given object exist in the 
/// collection or not. It iterates over the collection and checking if its items are
/// equal to the given argument using Equals(). 
/// 2. Equals() is also used by dictionaries for the type of key..
/// 3. And more....
/// ----
/// Since sometimes it is not sure that how many times struct will be used in 
/// Equals(), many devs decide to override it anyway.
/// </summary>
/// 
Point point2 = new Point(10, 20);
Point point3 = new Point(30, 40);
point3.Equals(point2);
Console.ReadKey();
readonly struct Point
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
        // This will make compiler to not use the Reflection.
        return obj is Point point && point.X == X && point.Y == Y ;
        // here obj will point to the object which is inside the Equals 
        // method as the argument.
        // Also you can not write "Point is  obj point" it has to be
        // "obj(i.e. parameter name) is Point(class name) point"
    }
}
///
/// If you right click on the struct's name(same works for classes also) and 
/// select quick action and refactoring,
/// you can select Equals method along with GetHashCode() or only standalone 
/// Equals() method. Then VS will ask us to which properties and fields you want 
/// this to work. There are option to implement the IEquatable interface and generate
/// overloads of the equality operators. We will also learn this later in the section.
/// -------------------
/// There is one more issue here, When we compare two objects of structs using the 
/// Equals, then it means one object which we are passing as the argument will 
/// get boxed. And boxing creates the impact on the performance. 
/// Lets see how to improve this in the next lecture.
///
