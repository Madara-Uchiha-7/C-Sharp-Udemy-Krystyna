

using System.Runtime.Serialization;

///
/// If none of the predefined exceptions meet our needs, we can create our own exception classes
/// by deriving from the Exception base class.
/// By convention we should end the class name with the word "Exception".
/// There are some guidelines we should follow regarding the constructors that our exception classes
/// should provide.
/// Let's see what public constructors we have available in the base Exception class so we can later add them to our type.
/// One is prameterless constructor.
/// The second constructor takes a string parameter representing the exception message.
/// Finally, we have the third constructor accepting an error message and an inner exception object.
/// To be consistent with how the System.Exception is implemented
/// we will add the same constructors to our class.
/// Check the code :
/// As you can see, the constructors with parameters call the base class constructors.
/// If we want to, we can add some extra data to this class by simply adding a new property.
/// For e.g. StatusCode and construtors created to handle message and innter Exception with StatusCode.
/// Now the users of this class can set all three of those properties.
///
Console.ReadKey();

[Serializable]
public class CustomException : Exception
{ 
    public int StatusCode { get; set; }   
    public CustomException() { }

    public CustomException(string message) : base(message) { }

    public CustomException(string message, Exception innerException) : base(message, innerException) { }

    public CustomException(int statusCode, string message) : base(message) { }

    public CustomException(int statusCode, string message, Exception innerException) : base(message, innerException) { }

    protected CustomException(SerializationInfo info, StreamingContext context) : base (info, context)
    {

    }
}

/// You may sometimes see that custom exceptions have two extra pieces of code.
/// Firstly, the Serializable attribute, which looks like:  [Serializable]
/// And secondly, an extra protected constructor:
/// protected CustomException(SerializationInfo info)
/// 
/// Firstly, Microsoft's guidelines on creating custom exceptions do not say that we must add those things.
/// Their recommendations end at 3 constructors and the name that ends with the Exception word.
/// 
/// Secondly, the use cases for such exceptions are quite specific and we do not always need to be ready
/// for them.
/// So you might see exceptions defined in this way when you work as a programmer.
/// If you are curious about those things:
/// https://learn.microsoft.com/en-us/dotnet/standard/exceptions/how-to-create-user-defined-exceptions
/// https://code-maze.com/dotnet-serialize-exceptions-as-json/
/// 