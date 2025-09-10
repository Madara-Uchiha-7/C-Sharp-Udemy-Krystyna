/*
We will see how to communicate with APIs using asynchronous methods from the HttpClient class.
Soon we will start working on this section assignment, which will involve getting data from an external
web API.

It is a good opportunity to talk about using async methods written by others.

We used HttpClient before, but back then, we didn't know what async methods were.

HttpClient is a class used for sending and receiving Http requests.

A typical use case for this class is to read data from web APIs.

Teachers api is not working. It has 100 quotes per page.
*/

// The 1st parameter will be the limit of how many quotes we need.
// 2nd is the page number.
// Getting data from an API is a time-consuming operation, and we want to be able to execute
// it in a non-blocking way. So, we will make GetQuotesAsync a async method.
// We will await the GetQuotesAsync because we need the quotes to show them on the web.
// 
using System.Text.Json;
try
{
    var quotes = await GetQuotesAsync(100, 1);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
static async Task<IEnumerable<Datum>> GetQuotesAsync(int numberOfQuotes, int pageNumber)
{
    // HttpClient object should be disposed of after use, so we will use the using statement.
    using var httpClient = new HttpClient();

    // We will also need to specify the endpoint we will query.
    // Link is not working anymore.
    var endpoint = $"https://quote-garden.onreader.com/api/v3/quotes?limit{numberOfQuotes}&page={pageNumber}";

    // Let's now use the HttpClient to get the data from this endpoint.
    // HttpResponseMessage is just a type representing the response.
    HttpResponseMessage response = await httpClient.GetAsync(endpoint);

    // We want to ensure the response was returned correctly.
    // We can achieve it by calling the EnsureSuccessStatusCode method on the response object.
    // If this response does not carry the result but information about an error, this method will throw an
    // exception.
    response.EnsureSuccessStatusCode();

    // The next step will be to access the content of the response body.
    // In the case of this API, the body is a Json string.
    // This is yet another async method, so we must await its result before we continue.
    string json = await response.Content.ReadAsStringAsync();

    // The last step will be deserializing this Json to a C# object.
    // But before we can do it, we must define C# types that will match the Json structure.
    // Take the JSON output and paste it into : json2csharp.com
    // Scroll below and tick Use Record Types.
    // Paste the JSON into left and click convert.
    // The Datum, Pagination and Root is from the json2csharp.com
    // Using those we can now deserialize the Json string to the Root type.
    // 
    var root = JsonSerializer.Deserialize<Root>(json);

    // Still, we don't want to operate on the Root type, but rather on Datum, which carries the crucial
    // data of each quote.
    // That's why we will return the Root's data from this method.
    return root.data;
    // Now we know the return type of this method should be Task of IEnumerable of Datum.
}

public record Datum(
    string _id,
    string quoteText,
    string quoteAuthor,
    string quoteGenre,
    int __v
);

public record Pagination(
    int currentPage,
    int nextPage,
    int totalPages
);

public record Root(
    int statusCode,
    string message,
    Pagination pagination,
    int totalQuotes,
    IReadOnlyList<Datum> data
);