// 1. We can not pass anything we want as the attribute parameter.
// You can check the error for below line. Error :
// "The attribute constructor parameter numbers has type list of int, which is not valid attribute parameter type".
[Some(new List<int> { 1, 2, 3 })]
public class SomeClass
{

}

public class SomeAttribute : Attribute
{
    public List<int> Numbers {  get; }

    public SomeAttribute(List<int> numbers)
    {
        Numbers = numbers;
    }
}
///
/// Valid attribute parameter types:
/// Simple types like bool, string or basic numeric types.
/// Enums.
/// The Type Object.
/// We can also use System.Object type.
/// 1D array of any of the above types.
/// The reason for this limitation is simple:
/// Attributes are metadata to a type, and types are defined at compile time.
/// Thats why, all the values passed as arguments to the attribute constructor must be backed in into the attribute at the
/// time of compilation.
/// 
///