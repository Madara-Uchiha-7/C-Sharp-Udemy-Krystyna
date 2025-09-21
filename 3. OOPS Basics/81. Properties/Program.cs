Rectangle rec1 = new Rectangle(5, 10);
// Using the setter
// For older syntax : This 15 will automatically go into the value
rec1.Width = 15;
// For older syntax : This will call the getter
Console.WriteLine(rec1.Width); 

public class Rectangle
{
    // The field that property is backing is called backing field
    // For eg if we use getter and setter on Width then Width will be a backing field
    private int Height;
    private int _width; // Name of the getter and this backing field shold not match in older syntax 

    public Rectangle(int height, int width)
    {
        Height = height;
        _width = width;
    }

    // Old way to define the getters and setters
    // Name of the Property should always start with Capital letter
    // Below's get and set are getter and setter

    public int Width
    {
        get
        {
            return _width;
        }
        set
        {
            if (value > 0)
            {
                _width = value; // Note how value is used without defining
            }
        }
    }


    /* Instead of methods we will use properties syntax to set and get the values
    public void SetHeight(int value)
    {
        if (value > 0)
        {
            _height = value;
        }
    }

    public int GetHeight() => _height;
    public int GetWidth() => _width;
    */


    // New way to define the setter and getter 
    // Remove the backing field i.e. field whcih you are going to use in the 
    // getter and setter and define following directly
    // e.g. : public int Width{get; private set;}
    // We can remove one accessor like : public int Width{get;}
    // If you remove the setter from new getter and setter syntax
    // Then there are only 2 ways to set the value to varibale 
    // 1. public int Width{get;} = 15;
    // 2. Use of Constructor. // How when we can declare the variable ?
    // I guess for pt 2. If we remove the setter part then we can declare the varaible
    // This above code will be changed to older syntax by the compiler with backing field
    // If you somehow need to access this backing field in other area 
    // then stick to older syntax

    // We can make older syntax shorter like : 
    /* public int Width
    * {
    *      get => return _width;
    *      set => _width = value; // But here you can not add the if also
    * }
    */
}

// We do not put paranthesis after the Properties like methods
// With properties we can use different access modifiers for getting and setting
/*
     * public int Width
     * {
     *      get
     *      {
     *          return _width;
     *      }
     *      // Now we can not use the setter outside the rectangle class
     *      // To use it in class we need to do e.g.: Width  = 10;
     *      private set
     *      {
     *          if (value > 0)
     *          {
     *              _width = value; // Note how value is used without defining
     *          }
     *      }
     * }
 */

// Properties like methods can be overriden unlike fields
// Fields should alywas be private
// Use properties to get and set