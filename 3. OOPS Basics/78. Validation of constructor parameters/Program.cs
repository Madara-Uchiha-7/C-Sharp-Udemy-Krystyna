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

class Rectangle
{
    // The problem : these below are still public which is risky 
    // User can change them. We will handle them in next lecture
    public int Width;
    public int Height;
    public Rectangle(int width, int height)
    {
        // For below methods:
        // Second argument i.e. for parameter name
        // Passing static value can be risky
        // For eg GetLengthOrDefualt(width, "Width") and GetLengthOrDefualt(height, "Height")
        // Because if they change on line 19, 20 we may forgret to change at other places.
        // That is, if we change the field name Width to wid then we may forget to change it in the
        // below method argument.
        // So there is one method in c# 
        // nameof(expression/varibale name) : Converts given value to string
        // Now even if we rename the Width field using control + R + R
        // everywhere including in here nameof(Width)
        // It will automatically convert it into a string
        // This way we do not need to find the string version of varible to rename it
        // I.e. nameof operator will give us the name of the variable as string instead of giving its value.
        Width = GetLengthOrDefualt(width, nameof(Width));
        Height = GetLengthOrDefualt(height, nameof(Height));
    }

    private int GetLengthOrDefualt(int length, string name)
    {
        int defaultValueIfNonPositive = 1;
        if (length <= 0)
        {
            Console.WriteLine($"{name} must be a positive number.");
            return defaultValueIfNonPositive;
        }
        
        return length;
    }

    public int CalculateCurcumference() => 2 * Width + 2 * Height;
    

    public int CalculateArea() => Width * Height;
}

