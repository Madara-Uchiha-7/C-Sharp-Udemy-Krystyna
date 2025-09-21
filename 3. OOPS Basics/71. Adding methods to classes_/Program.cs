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
    public int Width;
    public int Height;
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
    
    // Default access modifiers for methods are private
    // So we need to define them public if you want to use them outside the class
    // private methods are allowed to be accessed inside the class only
    public int CalculateCurcumference()
    {
        return 2 * Width + 2 * Height;
    }

    public int CalculateArea()
    {
        return Width * Height;  
    }
}


// In class we have defined 2 methods for circumference and
// area. Since we are calulating the logic in them,
// we have added the calculate before them
// Naming convention : Name of the method should always
// start from the verb