
public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }
    // Lets add the description property that will return the description of rectangle
    // Below line is get-only property
    public string Decription => $"A rectangle with Width {Width}" +
        $"and height {Height}"; // We used $ to keep writing the statement on next line
    // The above syntax is almost the same as the expression bodied methods
    // So similarly to methods if we used this Description property for 100 times
    // then this string will be build 100 times
    // If the logic here is more complex then it will cause the performance issue.
    // Rules is, one should not create performance heavy properties.
    // In such case you choose the methods
}