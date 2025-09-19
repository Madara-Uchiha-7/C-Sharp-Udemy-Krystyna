
using System.Text.Json;
using System.Text.Json.Serialization;

/// We will create a class that reads JSON strings from an open API.
/// We will learn the limitations of using the await keyword and how to make a method asynchronous.
/// Finally, we will practice deserializing JSON data to C# objects.
/// 
/// 

var baseAddress = "https://swapi.py4e.com/api/";
var requestUri = "planets";

IApiDataReader apiDataReader = new ApiDataReader();

// Since the method is asynchronous, we will add the await keyword here.
var json = await apiDataReader.Read(baseAddress, requestUri);

var root = JsonSerializer.Deserialize<Root>(json);

// If you check the root varibale then you will see that the data sourced from API transformed into a C# object.
foreach (var item in root!.results)
{
    Console.WriteLine(item.name);
}

Console.ReadKey();



interface IApiDataReader
{
    Task<string> Read(string baseAddress, string requestUri);
}

class ApiDataReader : IApiDataReader
{

    // We can only use the await keyword inside asynchronous methods. To make this method asynchronous
    // we must use the async keyword.
    // All asynchronous methods return Tasks.
    // If a Task produces some result, its type should be specified.
    // So, instead of string, our return type is Task<string>
    public async Task<string> Read(string baseAddress, string requestUri)
    {
        using var client = new HttpClient();

        client.BaseAddress = new Uri(baseAddress);

        var response = await client.GetAsync(requestUri);

        response.EnsureSuccessStatusCode();

        string json = await response.Content.ReadAsStringAsync();

        return json;
    }
}


// We need to transform the JSON into C# object using JSON deserialization.
// Debug the code, copy the JSON from the json variable.
// Type JSON to C# classes in google.
// Select json2csharp.com website.
// If you recall from the lecture about JSON, we can use various libraries to serialize and deserialize
// objects to and from this format.
// The most popular choices are the built-in library defined in the System.Text.Json namespace or the third
// party library called Json.NET developed by Newtonsoft.
// We use the built-in library, so scroll down and
// tick to "Use JsonPropertyName" checkbox.
// We should use the other checkbox if we used the Newtonsoft's library.
// In class settings, we can choose to use immutable types and records.
// We learned about them in this section and we know their benefits now.
// So tick, Generate Immutable classes and Use Record types.
// This way the generated types will be suited for use with the built-in JSON deserializer.
// Paste the JSON on the left side.
// Click convert.
// Copy the C# code from right side and paste it.
// All we need to do now is to deserialize the JSON string to the Root type.
// So add : var root = JsonSerializer.Deserialize<Root>(json); 
// Debug and check how code looks in root.

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
public record Result(
    [property: JsonPropertyName("name")] string name,
    [property: JsonPropertyName("rotation_period")] string rotation_period,
    [property: JsonPropertyName("orbital_period")] string orbital_period,
    [property: JsonPropertyName("diameter")] string diameter,
    [property: JsonPropertyName("climate")] string climate,
    [property: JsonPropertyName("gravity")] string gravity,
    [property: JsonPropertyName("terrain")] string terrain,
    [property: JsonPropertyName("surface_water")] string surface_water,
    [property: JsonPropertyName("population")] string population,
    [property: JsonPropertyName("residents")] IReadOnlyList<string> residents,
    [property: JsonPropertyName("films")] IReadOnlyList<string> films,
    [property: JsonPropertyName("created")] DateTime created,
    [property: JsonPropertyName("edited")] DateTime edited,
    [property: JsonPropertyName("url")] string url
);

public record Root(
    [property: JsonPropertyName("count")] int count,
    [property: JsonPropertyName("next")] string next,
    [property: JsonPropertyName("previous")] object previous,
    [property: JsonPropertyName("results")] IReadOnlyList<Result> results
);

