// --Notes by: Chinmay Kumar Borkar
// --Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// Let's start with an example to understand the problem.
// We have a very simple app that reads a number from the user and parses it to a decimal.

using System.Globalization;

Console.WriteLine("Enter the number");
string input = Console.ReadLine();
decimal result = decimal.Parse(input);
Console.WriteLine(result);

// Run the code
// enter 1.5
// Output will come 1.5

// Run code and again 
// and enter in the style of county Poland
// i.e. 
// 1,5
// the output will come as
// 15

// This is the problem.
// The decimal.Parse method tries to parse "1.5" to a decimal, but it doesn't recognize
// the comma as the separator between the number and the fraction part.
// This program is set to work using the American culture now, so it expects me to use a format with a dot.
// If the user interacts with an app
// we want this app to comply with the formatting the user is used to.
// In other words, a specific culture of the user should be used.
// The cultures we saw until now are specific cultures related to some language and country.
// But sometimes, we want our programs or parts of the programs to be culture invariant.
// For example, imagine our app saves some personal data like a date of birth.
// Users from around the world will use it and enter the dates in a format they are used to.
// The date strings will be parsed to DateTime objects and saved somewhere, for example, in some JSON files.
// But JSON is a textual format, so how those dates should be formatted?
// Well, since it is an internal data storage, it is better to stick to a single format so it can be
// easily deserialized back to C# without ensuring a correct culture is used.
// Otherwise, each date string from JSON would need to be parsed back to the DateTime object using a correct
// culture, which could be complicated. For cases like this
// we can use the invariant culture.
// Invariant culture is not related to a specific language or country.
// In practice it is quite similar to the American culture, but not exactly.
// Let's see how we can format a date as a string using the invariant culture.
// 
DateTime date = new DateTime(2025, 3, 2, 12, 16, 14);
Console.WriteLine(date.ToString("d", CultureInfo.InvariantCulture));
// As you can see, it is quite similar to what we saw for the American culture.
// But we have extra zeros before the day and the month.
// Invariant culture is always the same.
// It doesn't change between machines.
// 