// Catching exceptions using only System.Exception is a considered as
// a bad idea.  
// When we cath the exception, we should handle it appropriately.

Console.ReadKey();

int GetFirstElement(IEnumerable<int> numbers)
{
    foreach(int number in numbers)
    {
        return number; 
    }
    // This will be thrown if the collection is empty
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
        // Since in this catch block we are not throwing anything,
        // we have to return the value which is the return type of the method.
    }
    // If collection is null then it will fail the foreach of GetFirstElement
    // lets catch that exception also
    catch (NullReferenceException ex)
    {
        // NullReferenceException says somethig is null
        // But we know that the argument is null so 
        // we know code with throw NullReferenceException and
        // we will catch it here and pass it to constructor of the Exception ArgumentException
        // which will be assigned to the InnerException property of the new exception.
        // We say new exception wraps the old one.
        throw new ArgumentException("The collection is null", ex);
        // In above line, we did not throw the original exception
        // but a new exception storing the old exception in the InnerException Property.
    }
    // In this last catch we are not handling the exception like we did in the InvalidOperationException
    // This is perfectly fine
    // We do not need to handle all possible exceptions
    // In NullReferenceException we want user to understand that your input is null
    // so it is better that method throws the exception.
}



// We catch perticular exceptions so that we can add our message 
// and then we rethrow it. Using throw or throw ex (next lecture)