///
/// We will learn what data hiding is and why using it is a good idea.
/// We will also understand what members of a class are.
/// We will learn what access modifiers are and, specifically, the effect of public and private access modifiers.
/// Finally, we will see what the default access modifier for fields is.
/// 
/// 
/// When defining a class, we can decide whether its fields or methods can be accessed from the outside.
/// For example, we may not want anyone to be able to change the rectangle's width and height after they're
/// first set.
/// If those fields were publicly accessible, anyone could set them to invalid values.
/// 
/// With those fields being private and only set via the constructor,
/// We make sure that the rectangle objects are always valid.
/// 
/// 
/// Making the members of a class non-public is called data hiding.
/// Class members are anything that the class contains, especially fields and methods.
/// 
/// The rule of thumb is only to make a member public if it is necessary.
/// This is because making class members public can be a source of risk.
/// 
/// E.g. is List class with Count property(what property is, is given in the later lecture).
/// But its not allowed to change the Count property. Because changing it may cause the issues.
/// For example, someone could have added three elements to a list and then set the Count to five.
/// This count would obviously be invalid because it would not reflect the actual count of elements
/// stored inside. The List
/// class modifies the Count internally when methods like Add, Remove or Clear are called on it.
/// In this case, data hiding ensures that the state of the list object is valid. To control who can access
/// components of a class,
/// we use the access modifiers: a group of keywords like public, private and protected we can use with
/// class members.
/// 
/// For example, when a field or method is private, it can only be accessed from within the class it belongs
/// to.
/// 
/// If it is public, anyone can access it.
/// 
/// 
/// In last lecture,
/// We did not place any access modifier at width and height fields.
/// It means that default access modifier has been used, which in the case of fields, is private.
/// That's why we couldnt access them outside the rectangle class.
/// 
/// Making them public will change the behaviour.
/// 
/// 
/// Please be aware that the access modifiers should always be first in line, before the type of the field.
/// 
///

var rectangle = new Rectangle();

Console.WriteLine(rectangle.width);
Console.WriteLine(rectangle.height);

Console.ReadKey();

class Rectangle
{
    public int width;
    public int height;
}
