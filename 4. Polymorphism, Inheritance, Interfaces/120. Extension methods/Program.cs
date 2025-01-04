// Lets say there is a class which does not have one method which you need to add it
// in that class.
// But what if ther class is from Standard Library or some open source library.
// Here we have 2 choices:
// 1. We can create own class derived from the class you want to extend.
// and add the method. But their is a possibility that the parent class is sealed. 
// 2. Extension methods allows us to seemingly add methods to an existing
// type without modifying this type's source code.
// We will see second approch:
// Lets add a folder called Extensions.
// In that we have added a class called StringExtensions.
// Look at the code in it.
// Extension methods can only be defined in static classes.
// Extension method itself must have to static.
// This method takes the parameter of the type we want to extend.
// In our case we are adding the extension method to the string class which will
// count the number of lines for multiline string.
// Since, the extension is to the string class we are adding "string" in the method
// parameter after this keyword. "this" modifier is crucial to make this method an
// extension method. The parameter of the extended type must always be the first 
// parameter. So if you want to add more parameters then they must be after it.
// E.g. this string input, int number
// We can add extension methods of other types in that StringExtension file. But
// it is a good practice to have a seperate class for each extended type. 
// For eg. for DateTime extension method, new class will be used called
// DateTimeExtensions.
// Except "this" keyword, an extension method is a static method.

using Polymorphic.Extensions;

string multilineString = @"Hi,
how are you";

Console.WriteLine(multilineString.CountLines());
// multilineString.CountLines() is same way we call other string class method.
// Like stringType.methodName().
// Note: This adding of extension does not mean that this method is added in the string class.
// Even though we are calling the this method using instance variable of string class,
// the method CountLines() is still static.
// C# allows us to use the same syntax as it belongs to the string type
// because it is the extended method.
// We can also call it like other static method.
Console.WriteLine(StringExtensions.CountLines(multilineString));

// You can use @ symbol to add the multi line string in the varibale.
// Add it before the "

// Extenstion methods allows us to add the functionality to 
// classes which we do not have the access.
// This also allows us to add methods to types that can not have methods like
// enums type.

Console.WriteLine(Season.Spring.Next());
public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}
// Lets add a method called Next which will return a next season of one we provide.
// In our current extension folder add
// SeasonExtension


// I tried below line:
// Console.WriteLine(Season.Spring.Next());
// After the declaration and definition of the Season enum,
// but it gave me error.
// I think it is now allowed to do so.