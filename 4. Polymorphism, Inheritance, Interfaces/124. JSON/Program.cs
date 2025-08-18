// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// JSON : Javascript Object Notation
// Library is a collection of prewritten code that we can use to make our program easier.
// E.g. C# standard library: string, DateTime...
// Since .Net Core 3/1 (2019), JsonSerializer is part of .NET

using System.Text.Json; // For JsonSerializer.Serialize(object)

Person person = new Person
{
    FirstName = "Chinmay",
    LastName = "Borkar",
    YearOfBirth = 1996
};

// We will serialize the person object into JSON
// This will convert our above object to JSON format.
string asJson = JsonSerializer.Serialize(person);
Console.WriteLine($"As Json {Environment.NewLine}{asJson}");

string personJson = "{\"FirstName\":\"Chinmay\",\"LastName\":\"Borkar\",\"YearOfBirth\":1996}";
// "\ is telling C# compiler that ignore the double-quotes becase those are the part of the string and not end of the string"
Person? person1 = JsonSerializer.Deserialize<Person>(personJson);
// Added ? because it was showing the warning that o/p of JsonSerializer.Deserialize<Person>(personJson); may come null.
// To handle it I added ?

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int YearOfBirth { get; set; }
}

// https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/how-to?pivots=dotnet-8-0
// https://www.w3schools.com/js/js_json_intro.asp