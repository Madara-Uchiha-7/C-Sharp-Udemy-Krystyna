///
/// We'll learn what exception filters are and how they can help us better control what
/// exceptions will be processed by a catch block.
/// We learned already that we can define multiple catch blocks, handling different types of exceptions,
/// but it is sometimes the case that the code inside the try block might throw exceptions that are all
/// of the same type and only differ by the values of properties.
/// In this case, we may want to handle them differently, but how can we distinguish them if their type
/// is the same?
/// Well, we can do it by using the exception filters.
///

// Let's imagine SendHttpRequest method sends an HTTP request.
// If this operation succeeds, some data will be returned.
// But there are many scenarios when an HTTP request may fail.
// HTTP requests have special codes representing the status of an operation.
// For success, we have status 200, which means everything went well.
// Status code 403 means that it was forbidden to access some resource.
// 404 means that the resource was not found.
// For example, because the address is wrong. Or 500 means that the server had some internal error.
// Let's now imagine that when this method cannot fetch data, it throws an exception and its message carries
// the number with the HTTP status code.
// All those exceptions will be of the same type and will only differ by this status code.
// Lets see the code:
// The first one from the top for which the condition is met will be executed.
// For e.g. (ex.Message.StartsWith("4"))  will be true for both 403 and 404 status codes, but still, they would be
// handled in above catch blocks because they are on the top.
//
try
{
    var dataFromWeb = SendHttpRequest("www.someaddress.com/get/someResource");
}
catch (HttpRequestException ex) when (ex.Message == "403")
{
    Console.WriteLine("It is forbidden to access this resource.");
    throw;
}
catch (HttpRequestException ex) when (ex.Message == "404")
{
    Console.WriteLine("The resource not found.");
    throw;
}
catch (HttpRequestException ex) when (ex.Message.StartsWith("4")) 
{
    Console.WriteLine("The resource not found.");
    throw;
}
catch (HttpRequestException ex) when (ex.Message == "500")
{
    Console.WriteLine("Internal server error.");
    throw;
}
Console.ReadKey();