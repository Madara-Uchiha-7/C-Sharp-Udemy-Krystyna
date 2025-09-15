/// Now, once we know how to define custom exceptions, we should learn when we should do it and when to
/// use the built-in exception types.
/// We will also understand what the principle of least surprise is.
/// 
/// First advice is to always think twice before creating a custom exception.
/// Perhaps there is already an exception that we can use.
/// 
/// For e.g for condition
/// if (yearOfBirth < 1900 || yearOfBirth > DateTime.Now.Year)
/// {
///     throw new ArgumentOutOfRangeException("The year of birth must be in 1900 and current year");
/// }
/// Here one could argue that when it comes to the validation of the year of birth, we could create a custom
/// PersonYearOfBirthOutOfValidRangeException.
/// But would it really carry any more information than the ArgumentOutOfRange exception with a well
/// defined message that we have here?
/// I wouldn't say so.
/// 
/// If we created custom exceptions for situations like this, our code would soon bloat to an enormous
/// size, and 90% of it would be custom exception classes.
/// 
/// Also, keep in mind that since the built-in exceptions are widely known in the C# community, other
/// developers will expect those exceptions to be thrown.
/// I think if a developer wanted to create a Person object and knew the constructor might throw an exception,
/// they would expect the built-in exceptions like ArgumentException, ArgumentNullException or ArgumentOutOfRangexception.
/// 
/// Sure, they can dig into the code and see for themselves what type of exceptions are thrown, but it
/// requires significant effort, especially in bigger projects.
/// 
/// Not to mention that they may not have access to the source code if they use a library coded and built
/// by someone else.
/// 
/// When programming, we should follow the principle of least surprise.
/// It says that the code should behave in a way that most users will expect it to behave.
/// In other words, even if other developers investigate our code in detail, they should not be surprised
/// at all by what they find there.
/// 
/// Ideally, they should think "I did not even need to check that.
/// What my first instinct told me about this code was correct." Since most developers will in the first
/// place expect the built-in exception types we should use them when they are appropriate.
/// 
/// Still, there may be situations when built-in exceptions are not enough.
/// 
/// Now,
/// Consider below code:
/// Imagine we have some complex process in which many things may go wrong.
/// This method connects to some service, authorizes the user and then retrieves some data as JSON.
/// Finally, it tries to parse this JSON to some C# type.
/// If in this method we decide to only throw the built-in exceptions, it may turn out that each step throws
/// the InvalidOperationException because we don't really see any more fitting choice.
/// If we wanted to handle each of those exceptions differently, we can define exception filters.
/// In this case, they could only base on the exception message.
/// But what if some developer comes and changes the Message while throwing the exception and
/// it does not match to our when condition. In status code in custom filter lecture developer can not change the 
/// code because it is fixed, but this is not the case here.
/// 
/// So, it would be much more reliable to simply catch various exception types, but for that we need types
/// that are actually appropriate for a given problem.
/// That's why here we could consider defining exceptions like ConnectionException, AuthorizationException
/// DataAccessException and JsonParsingException.
///

try
{
    ComplexMethod();
}
catch(JsonParsingException ex)
{
    Console.WriteLine("Unable to Parse JSON. JSON body is: " + ex.JsonBody);
    throw;
}
Console.ReadKey();

void ComplexMethod()
{
    // Step 1: Connecting
    throw new ConnectionException("Can not connect to service.");

    // Step 2: Authorizing
    throw new AuthorizationException("Can not authorize the user.");

    // Step 3: Retrieving data as JSON
    throw new DataAccessException("Can not retrieve data.");

    // Step 4: Parsing the JSON to some C# types.
    throw new JsonParsingException("Can not parse JSON data.");
}



/// Another argument in favor of creating custom exceptions is that for different exceptional situations,
/// we may need different additional data.
/// For example, if parsing the retrieved data to a custom C# type JsonParsingException did not work, it might be useful
/// to read the JSON string from the exception property.
/// In this case, the built-in exception types would not work because they don't have any property that
/// may store the string except for the message, which would rather be short and readable and not contain JSON.
/// But now, since we are the authors of the JsonParsingException type, we can enrich it with any property
/// we want. For e.g.
/// check below code and check catch(JsonParsingException ex)
/// 
public class JsonParsingException : Exception
{
    public int JsonBody { get; set; }
    public JsonParsingException() { }

    public JsonParsingException(string message) : base(message) { }

    public JsonParsingException(string message, Exception innerException) : base(message, innerException) { }

    public JsonParsingException(int jsonBody, string message) : base(message) { }

    public JsonParsingException(int jsonBody, string message, Exception innerException) : base(message, innerException) 
    {
        JsonBody = jsonBody;
    }
}