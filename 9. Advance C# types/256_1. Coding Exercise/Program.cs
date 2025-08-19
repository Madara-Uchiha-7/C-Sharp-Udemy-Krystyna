/// <summary>
/// Attributes - MustBeLargerThanAttribute
/// Define an attribute for which it will be possible to use it like this:
/// public class SomeClass
/// {
///     [MustBeLargerThan(100)]
///     public int Value { get; }
/// }
/// 1. This attribute must simply carry the data given in the parenthesis. It should keep it in a property called Min.
/// 2. This attribute should be only applicable to properties.
/// </summary>

//your code goes here
[AttributeUsage(AttributeTargets.Property)]
public class MustBeLargerThanAttribute : Attribute
{
    public int Min { get; }
    public MustBeLargerThanAttribute(int min)
    {
        Min = min;
    }
}


///
/// Some question and answers: (Quiz after the lecture 257)
/// Question 1: Which of the following can be found in the Type object?
/// Properties and fields of type. 
/// The list of this type's constructor.
/// All methods of this type. 
/// The base class and implemented interface.
/// 