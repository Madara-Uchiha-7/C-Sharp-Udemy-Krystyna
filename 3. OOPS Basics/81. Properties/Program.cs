Rectangle rec1 = new Rectangle(5, 10);
// Using the setter
// For older syntax : This 15 will automatically go into the value
rec1.Width = 15;
// For older syntax : This will call the getter
Console.WriteLine(rec1.Width); 

public class Rectangle
{
    /*
    We are first discussing the old way to define the properties. 
    To do that We first need to define the private field Which will start with the underscore as we know. 
    Then that same name we will use to define the property with capital letter.
    As you can see we have defined the private field _width and then we have defined the property Width.
    That Width will be a public property.
    Name of the property should always start with Capital letter.
    Their names should be nouns, not verbs.
    This Width property exposes 2 accessors getter and setter.
    The role of these 2 is same as the getter and setter methods.
    Since accessors are like methods, we can add any other code to them.
    For example, we can add validation to the setter. Which we have done : if (value > 0).
    Please notice this special variable called value.
    This is simply the value that is being assigned to the property
    from outside of the class. e.g. we have done : rec1.Width = 15; 
    This 15 will automatically go into the value and assign it to the private field _width.
    we use properties exactly as we use fields.
    As we have done : rec1.Width = 15; and Console.WriteLine(rec1.Width); 
    So, instead of using the private field of _width, we are using the public property Width.
    We can use different access modifiers for getting and setting with properties.
    The most common use case is to have a public getter and a private setter.
    e.g. public int Width { private set { if (value > 0) { _width = value; } } get { return _width; } }
    The field that the property is wrapping is called a backing field.
    Hence _width is the backing field for the Width property.
    */

    private int Height;
    private int _width; 

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
    // What is interesting, the compiler actually translates this single line to a code as we had before,
    // We can remove one accessor like : public int Width{get;}
    // If you remove the setter from new getter and setter syntax
    // Then there are only 2 ways to set the value to Property. 
    // 1. public int Width{get;} = 15;
    // 2. Use of Constructor. 

    // We can make older syntax shorter like : 
    /* public int Width
    * {
    *      get => return _width;
    *      set => _width = value; 
    * }
    */
}

// We do not put paranthesis after the Properties like methods
// With properties we can use different access modifiers for getting and setting
/*
E.g of Private setter 
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