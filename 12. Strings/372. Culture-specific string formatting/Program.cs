// --Notes by: Chinmay Kumar Borkar
// --Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------


// Different cultures have different ways of formatting some textual information.
// Let's consider fractions and dates.
// In teacher's culture, it is typical to write numbers with fractions like this 
// 1,5 
// and dates like this.
// 02.03.2025
// But this is not the case everywhere in the world.
// For example, in the United States, numbers are written with a dot, not a comma.
// 1.5
// Dates are written with slashes and the month is not in the middle.
// 3/2/2025
// This can make our lives as programmers quite complicated.
// Bugs related to formatting are one of the most common.

// Let's see culture-specific formatting in code.
// 

using System.Globalization; // For CultureInfo

DateTime date = new DateTime(2025, 3, 2, 12, 16, 14);
decimal number = 1.4m;

// I print the date using the short date pattern.
// As you can see, the date time exposes an overload of the ToString method, accepting the same format
// as the one we've learned about in the previous lecture.
Console.WriteLine(date.ToString("d")); // 3/2/2025
Console.WriteLine(number); // 1.9

// This looks to me like the American way of printing things, but let's make sure this is the case.
// 
// Let's add code printing the current culture to the console.
// 
CultureInfo cultureInfo = CultureInfo.CurrentCulture;
Console.WriteLine(cultureInfo); // en-US is printed
// The first part is the language code, and the second part is the country code.

// We can change the culture used by the application by assigning a new culture info object to the current
CultureInfo.CurrentCulture = new CultureInfo("pl-PL");
Console.WriteLine(date.ToString("d"));
Console.WriteLine(number); 