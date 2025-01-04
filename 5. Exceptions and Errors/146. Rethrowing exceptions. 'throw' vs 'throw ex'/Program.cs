///
/// Using catch we catch the exception and we can see or use it using 'ExceptionName ex'
/// parameter.
/// When we throw the same exception which is catched then it is called 'Exception
/// Rethrowing'
/// E.g.
/// catch (NullReferenceException ex) { throw ex; }
/// If done like above, i.e. not giving any additional information then it has no point 
/// because without this above catch, it works as same.
/// Re throwing the exception makes sanse when you do addtional steps in it, like 
/// adding your own custom message.
/// E.g.:
/// catch (NullReferenceException ex) 
/// {
///     Console.WriteLine("Sorry!!! unexpected error...");
///     throw ex; 
/// }
///

// Catching exceptions using only System.Exception is a considered as
// a bad idea.  
// When we cath the exception, we should handle it appropriately.


// Since our method throws the exceptions 
// we need to catch them using try catch, so the calling of the method will
// come inside the try catch block.

try
{
    IsFirstElementPositive(null);
} 
catch (NullReferenceException ex)
{

}

Console.ReadKey();

int GetFirstElement(IEnumerable<int> numbers)
{
    foreach (int number in numbers)
    {
        return number;
    }
    throw new InvalidOperationException("The collection can not be empty");
}

bool IsFirstElementPositive(IEnumerable<int> numbers)
{
    try
    {
        int firstNumber = GetFirstElement(numbers);
        return firstNumber > 0;
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine("The collection is empty!");
        return false;
    }
    catch (NullReferenceException ex)
    {
        Console.WriteLine("Sorry!!! unexpected error...");
        throw ex;
    }
    // If NullReferenceException comes, above catch will be used 
    // and stacktrace will show line 64 on top because here we are throwing the 
    // ex.
    // But we write only throw instead of ex. Then the stack trace will contain 
    // more data. 
    // It will not only show that error is thrown from IsFirstElementPositive
    // but also will show that GetFirstElement is also responsible.
    // but throw ex will not show GetFirstElement() method where
    // the method was originally thrown.
    // This happens because the throw keyword preserves the stacktrace.
    // Means stack trace will point to the method which caused the scene.
    // While throw ex does not and it will look like that is the place where
    // it is thrown. It will seem like the exception was thrown from the place
    // of its catching and rethrowing. It is sometimes called as the 
    // resetting the stacktrace. It means that all info stored in the stack trace
    // before reaching the 'throw ex' command will be lost. This is not good.
    // So it is better to use the throw instead of 'throw ex'.
    // Now why to allow the 'throw ex' in the first place.
    // Remember, that ex is the object and we are allowed to throw the objects
    // like we did in the last code 
    // e.g. throw new ArgumentException("The collection is null", ex);
    // So on above line we are doing same that is creating the object of
    // ArgumentException and throwing it which is similar to 'throw ex'
    // So, to allow
    // throw new ArgumentException("The collection is null", ex) --> this way
    // C# has not stopped us for using 'throw ex' because it is same
    // and we need to use this functionality.
    // But when we do throw
    // new ArgumentException("The collection is null", ex)
    // in the catch like we did in
    // last code, this will preserve the stacktrace unlike 'throw ex'. But 
    // it will preserve it in the innerException->stacktrace in quick watch.
    // This happens because we are passing the ex i.e. original Exception
    // in the parameter.
    // This innerException->stacktrace will point out from error is originated.
    // Note: In the code where the we are giving the method call (line 31)
    // in that catch you will have to use ArgumentException in parameter
    // if you are going to try returning the 'throw new ArgumentException'
    // instead of 'throw ex'

}



// Only using the throw will throw the same exception i.e. same as 'throw ex'