Rectangle rectangle1 = new Rectangle(5, 10);
Console.WriteLine("Width is: " + rectangle1.Width);
Console.WriteLine("Height is: " + rectangle1.Height);
Console.WriteLine("Circumference is: " + rectangle1.CalculateCurcumference());
Console.WriteLine("Area is: " + rectangle1.CalculateArea());

Rectangle rectangle2 = new Rectangle(2, 3);
Console.WriteLine("Width is: " + rectangle2.Width);
Console.WriteLine("Height is: " + rectangle2.Height);
Console.WriteLine("Circumference is: " + rectangle2.CalculateCurcumference());
Console.WriteLine("Area is: " + rectangle2.CalculateArea());

Console.ReadKey(); // To stop teminal closing automatically


/* const keyword:
 * This can be assigned to the variable, fields
 * It can be done at declaration and they must be given a compile time constant value
 * They can not be modified afterwords.
 * With const you can not use var keyword 
 * Names of const fields and variables should always start from the capital letter
 */
public class Rectangle
{
    // The problem : these below(Width, Height) WERE  public which was risky 
    // User could change them.
    // readonly : can be assigned at the declaration or in the constructor
    // Like line 42 and 43
    // After the object is constructed, it will not be possible to change its value
    // Making field readonly makes it immutable i.e. 
    // Once obj is created then it will never be modified
    // It is fine to if value is evaluated at runtime for readonly
    public readonly int Width; // Only declaration like this is not allowed in const, we must give value for const
    public readonly int Height;
    // Now we can't change these values once obj. is created
    // So a situation where you want this to be availbale outside the class
    // But don't want it to change then we can do this.
    // like Lenght field from string class.

    public Rectangle(int width, int height)
    {
        Width = GetLengthOrDefualt(width, nameof(Width));
        Height = GetLengthOrDefualt(height, nameof(Height));
    }

    private int GetLengthOrDefualt(int length, string name)
    {
        const int DefaultValueIfNonPositive = 1;
        if (length <= 0)
        {
            Console.WriteLine($"{name} must be a positive number.");
            return DefaultValueIfNonPositive;
        }

        return length;
    }

    public int CalculateCurcumference() => 2 * Width + 2 * Height;


    public int CalculateArea() => Width * Height;
}

