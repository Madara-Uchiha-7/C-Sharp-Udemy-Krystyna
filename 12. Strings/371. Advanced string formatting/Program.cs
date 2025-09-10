// --Notes by: Chinmay Kumar Borkar
// --Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------


// We saw it already when formatting a table of items.
// e.g.
// Console.WriteLine("{0, 15}|", property.Name);
// This above line is helpful while creating a table like structure.
// Nowadays, it is string.Format used, but before string interpolation was added to C# with language version
// 6, string.Format was the main way to format strings.
// Some libraries still use an identical mechanism as string.Format.
// Also, it is common in older code, so overall it's better to know it.
//

int number1 = 100;
int number2 = 200;
string text = string.Format("Number 1 is : {0}, number 2 is : {1}", number1, number2);
Console.WriteLine(text);
// The first parameter is a string with numbered placeholders.
// Then we can pass any number of parameters and they will be injected in places of the placeholders.
// Overall, this mechanism is called composite formatting.
// It allows us to insert values into a string at specific locations.
// So at a high level it is similar to string interpolation but less convenient.
// Also, it is more error prone.
// If I skip one parameter by accident, error will come.
// On the other hand, if I passed three parameters here, so one more than expected, the last parameter
// would simply be ignored. With string interpolation such mistakes simply does not happen.
// 

// But sometimes we need more control, for example, about the spacing or the exact format of some value.
// In that case, we can use more advanced features of composite formatting.
// It involves specifying a bit more than just an index in the placeholder.
// The general recipe for the format item.
// General Pattern:
// {index [,alignment][:formatString]}
// The only required part is the index which we just saw.
// If we want to, we can add the alignment after the comma.
// {1, 10}
// So, for example, such a format item will describe the item at index one that will be aligned to the
// right and padded with white spaces. 
// So the whole text occupies a space for 10 characters.
// If it was -10, it would be aligned to the left.
// 

text = string.Format("Number 1 is : {0}, number 2 is : {1, 10}", number1, number2);
Console.WriteLine(text); // Number 1 is : 100, number 2 is :        200

// The last part of the format item, which is also optional, is the format of the string.
// There are many formats available.
// For example, they can allow us to print numbers with the symbol of a currency or rounded to a specific
// number of places after the point.
// 

text = string.Format("Number 1 is : {0}, number 2 is : {1, 10:C}", number1, number2);
Console.WriteLine(text); // Number 1 is : 100, number 2 is :    $200.00

// More formats:
// https://learn.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting#format-string-component


decimal someDecimalNumber = 1.46m;
// Check the output to understand below comments.
// I format it as a currency, but with three decimal places.
string one = string.Format("Number is : {0:C3}", someDecimalNumber);
// I format it as a fixed point number rounded to one place after the point.
// That's why 1.46 has been rounded to 1.5. And here I format it as a percent.
string two = string.Format("Number is : {0:F1}", someDecimalNumber);
// I format it as a percent. 
// It was multiplied by 100 and printed with the percent symbol.
string three = string.Format("Number is : {0:P}", someDecimalNumber);

Console.WriteLine($"{one}\n{two}\n{three}");

// String formatting is not only applicable to numbers.
//

DateTime someDateNumber = new DateTime(2024, 5, 6, 12, 54, 12);
// Check the output to understand below comments.
// The first format is called a short date pattern, and we can see why; it is pretty compact.
string oneDate = string.Format("Date is : {0:C3}", someDateNumber);
// The second is a long date pattern, and indeed it is longer.
string twoDate = string.Format("Date is : {0:F1}", someDateNumber);
// I use my own pattern. Uppercase 'M' letters mark places where the digits of the month will be
// injected, and lowercase 'y' letters, the places for the digits of the year.
string threeDate = string.Format("Date is : {0:P}", someDateNumber);

Console.WriteLine($"{oneDate}\n{twoDate}\n{threeDate}");

// The last thing, each call to the string.Format can be converted
// to an interpolated string.
// This works because, as it turns out, string interpolation is just a syntactic sugar for a call to
// the string.Format method.
// Let's ask Visual Studio to change some of those lines to string interpolation.
// 
// Below select over string from string.Format,
// on left one symbol will come, click on it and then 
// select convert to interpolated string.
Console.WriteLine(string.Format("Date is : {0:F1}", someDateNumber));
// You will get above line to be converted into:
Console.WriteLine($"Date is : {someDateNumber:F1}");

