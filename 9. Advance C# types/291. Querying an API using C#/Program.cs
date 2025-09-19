///
/// We will learn how to read data from a public API in our C# programs.
/// We will also see asynchronous methods and learn how to await their execution.
/// 
/// Even open APIs usually require some authorization.
/// It most often means we need to create an account on some portal to get the API key, without which we
/// would not be able to query this API.
/// 
/// Luckily, there are some APIs that are completely open and we don't even need to create an account to
/// use them.
/// 
/// Please notice that even such APIs usually limit the requests we can make to them, but the limit is
/// most often quite high, like 1000 or 10,000 a day.
/// 
/// In the resources of this lecture, you will find a list of such completely open APIs:
/// https://mixedanalytics.com/blog/list-actually-free-open-no-auth-needed-apis/
/// 
/// C# Standard library exposes classes allowing us to query APIs in just a few lines.
/// The main class we will use is called HttpClient.
/// This class is disposable, so we will use it with the using statement.
/// 

using var client = new HttpClient();

// Now we must tell it what the base address of this API is.
// The base address is everything up to the "API" word in the URL.
// Uri : stands for Uniform Resource Identifier.
client.BaseAddress = new Uri("https://swapi.py4e.com/api/"); // Do not remove the / after the api word.

// Now we will call the GetAsync method on the HttpClient providing the rest of the URL as the parameter.
var response = await client.GetAsync("planets");
// The type of reuslt we will get from GetAsync() is a nullable Task<HttpResponseMessage>?.

/// Let's understand what it means.
/// The GetAync method is asynchronous.
/// Asynchronous methods are designed to run in a non-blocking way, allowing other code to continue to
/// execute while they are running.
/// var response = client.GetAsync("planets");
/// The return type of above line is Task of HttpResponseMessage, not the HttpResponseMessage itself.
/// This type represents a task of getting some value, and only when this task finishes its work we will
/// have access to this value.
/// The thing that we need to know now is that if we want to wait till the method finishes its work and
/// can give us the result, we must use the await keyword.
/// Once you add the await keyword the result is no longer a Task of HttpResponseMessage, but the HttpResponseMessage itself.
/// 
/// We tell the code wait till this task is finished and then give me its result.
/// 
/// The next step would be making sure that the result actually carries the data we wanted and not, for
/// example, information that the server is unavailable.
/// We can do that using response.EnsureSuccessStatusCode();
/// This method would throw an exception if getting the data from the API was impossible.
/// 
response.EnsureSuccessStatusCode();

/// Finally, we want to extract the JSON string from this response.
/// For that, we can use another asynchronous method.
/// 
string json = await response.Content.ReadAsStringAsync();

Console.ReadKey();


// I think we should enclose this logic in a class so we can reuse it when we use another API
// when working on the assignment. Let's do it in the following lecture.