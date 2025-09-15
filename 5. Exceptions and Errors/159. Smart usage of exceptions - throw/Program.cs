///
/// When it comes to smart usage of exceptions
/// there are two areas we should consider: when to throw them from our code and when to catch them.
/// 
/// In this lecture, we'll focus on understanding when throwing exceptions explicitly from our code is a
/// good idea.
/// 
/// We said before that it's okay to throw an exception if the assumptions a method
/// operates on are not met.
/// We saw an example with a method that returns the first element of a collection.
/// It cannot do it if the collection is null or empty.

int GetFirstElement (IEnumerable<int> numbers)
{
    foreach(int number in numbers)
    {
        return number;
    }
    throw new InvalidOperationException("The collection can not be empty.");
}

/// If a developer uses this method with a null or empty collection, they simply make a coding mistake.
/// As the creators of the GetFirstElement method, we are not responsible for other people's mistakes.
/// We could and we should throw an exception as we do not have any other reasonable choice. In this case
/// this exception will communicate to the users of this method that they need to add an if statement in
/// their code, validating if the collection is not null and not empty.
/// For e.g. if (number.Count > 0 && number is not null)  GetFirstElement(numbers);
/// 
/// Sometimes you may see or hear statements that exceptions should only ever be thrown on developers mistakes.
/// Teacher says it is a bit too extreme, even if it is truly the case in many situations.
/// 
/// Let's consider the following example.
/// We create a method that deserializes people data from a JSON file read from some external source.
/// We are not the owners of this source.
/// Whatever it is, a database, a web service, or a file.
/// We are not 100% sure if it always contains valid JSON.
/// For example, someone may have removed a brace or a comma by mistake.
/// If there is some issue in the JSON, it will not be possible to deserialize it and this method will
/// throw an exception.
/// But does it really mean a developer made a mistake?
/// 
/// 
/// Let's compare it with dividing two numbers in some calculator app.
/// If we divide by zero and an exception is thrown, we can say that it could be avoided if the developer
/// added an if statement checking if the divisor is zero. Could we do a similar thing for deserializing JSON?
/// 
/// Well, technically we could, 
/// e.g. by creating IsValidJson() method.
/// but it would be such a complex process that it is actually faster just
/// to try to deserialize it and see if an exception was thrown.
/// So in this case, an exception may be thrown, but I would not say it means a developer made a mistake
/// and that the code needs to be changed. After such an exception is caught
/// we must decide what to do with it.
/// 
/// We may assume that this JSON must be valid and if it isn't, the app cannot continue.
/// We can return a null or empty list from this method.
/// It all depends on our needs and how we want this method to behave.
/// So in this case, checking upfront if the exception will be thrown, was not making a lot of sense.
/// 
/// Still, in many situations, exceptions can be avoided.
/// Let's see a couple of more examples of when exceptions are typically thrown and how the developers could
/// adjust their code to avoid them.
/// 
/// For the divide by zero exception, it is simple.
/// We should just check if the divisor is not zero and then a try-catch block
/// expecting a divide by zero exception will not be needed.
/// 
/// An error in reading a non-existent file could be avoided if we first checked if the file existed.
/// 
/// Creating a person with an empty name or year of birth equal to 3000 would not happen if we first checked
/// what the user entered into a form.
/// In all those situations, the developers of those methods made reasonable decisions to throw exceptions
/// from their code.
/// 
/// 
/// What about low-level exceptions?
/// For example, the StackOverflowException or OutOfMemoryException?
/// We can't really write an if statement that will save us from them.
/// Does it mean that when they are thrown it doesn't indicate a developer's mistake?
/// Well, not really.
/// If they are thrown, something definitely needs to be fixed
/// in our program. With the StackOverflowException, we most likely call some recursive method without
/// any stopping condition.
/// We must find it and modify it so it doesn't cause infinite recursion.
/// 
/// The OutOfMemoryException usually means one of two things.
/// Firstly, the application may have memory leaks, which means that the unused memory is not properly
/// freed.
/// And secondly, we may just consume too much memory for our capabilities.
/// 
/// This is in line with another common piece of advice regarding throwing exceptions: that if normal program
/// flow regularly runs into exceptions, you're doing something wrong.
/// 
/// 
/// For example, consider an app with a login screen where the user enters the login and password.
/// And user enters then wrong password then we should not throw the exception from our code in such case.
/// Incorrect passwords are entered by users all the time and there is nothing exceptional about that.
/// 
/// A method validating the password should rather return a boolean.
/// 
/// Exception should be used for exceptional behavior, not for controlling the flow of the program.
/// 
/// 
///