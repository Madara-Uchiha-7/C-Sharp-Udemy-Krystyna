// Building data with methods that operate on this data (in single class) is encapsulation
// Encapsulation is Data and methods are enclosed in class.


Rectangle rectangle = new Rectangle(5, 10);
ShapeMeasurementsCalculator calculator = new ShapeMeasurementsCalculator();
Console.WriteLine(calculator.CalculateRectangleCircumference(rectangle));
Console.WriteLine(calculator.CalculateRectangleArea(rectangle));
class Rectangle
{
    public int Width;
    public int Height;
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
}
// We will use diff class to write the logic of area and circumference
// And class Rectangle will use that class method
// Now Rectangle class is only a container for the data
// The lecture 71 code uses encapsulation while this code does not use it.
// In this case 71 code approch is better which uses the encapsulation
// Also Rectangle class fields are public right now, in reality it won't be 
// For now the other class can change the values of those fields which is risky
// So it is better to write the logic of that class in that class itself
// Data hiding and encapsulation is not same. 
// Encapsulation : Bundling data with methods that operate on it in the same class.
// Data Hiding : Making fields private or public 
class ShapeMeasurementsCalculator
{
    public int CalculateRectangleCircumference(Rectangle rect)
    {
        return 2 * rect.Width + 2 * rect.Height;
    }
    public int CalculateRectangleArea(Rectangle rect)
    {
        return rect.Width * rect.Height;
    }
}
