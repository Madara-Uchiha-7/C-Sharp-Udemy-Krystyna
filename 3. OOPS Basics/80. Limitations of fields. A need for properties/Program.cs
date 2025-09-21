// Readonly does not allow us to update the value
// But what if we want to update it inside that preticular class
// For E.g. Public for reading and private for writing

public class Rectangle
{
    // Fields _height and _width
    private int _height;
    private int _width;

    public Rectangle(int height, int width)
    {
        _height = height;
        _width = width;
    }

    // This below is a method to get the value
    // This is also called as the getters
    // Sometime we need to set the values to variables
    // in those cases we also use methods called as setters
    // These getters and setters are called Properties
    public int GetHeight() => _height;
    public int GetWidth() => _width;
}
