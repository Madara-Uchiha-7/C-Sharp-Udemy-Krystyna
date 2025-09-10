///
///
/// We will learn how to deal with exceptions thrown in async methods.
/// Lets add a writeLine in the while and add a exception the the ProcessAsync.
/// 
/// We will see that even though an exception was thrown in the ProcessAsync method, we reached the loop without
/// issues and the program did not crash.
/// 
/// While debugging 
/// once the control reaches Console.ReadKey();
/// if you take a look at the task from var task = ProcessAsync("Hello"); 
/// using quick watch, then you will see
/// Status as Faulted. It will also have the exception object.
/// This is an AggregateException which carries all exceptions thrown within the task.
/// So this is the behavior we saw for tasks before.
/// 
/// First of all, the application doesn't crash.
/// No exception is propagated to the code that started the task, so there would be no point in using the
/// try-catch block.
/// The task becomes faulted and carries an AggregateException.
/// If we wanted to handle this exception, we would need to make sure that the task is no longer running
/// and then check the Status and the Exception property.
/// If you do
/// await ProcessAsync("Hello"); instead of : var task = ProcessAsync("Hello");
/// then the exception will be thrown which will crash the application.
/// It means we could surround "await ProcessAsync("Hello")" part with a try-catch block and handle this exception.
/// But this will cause the compiler to wait for the completion of ProcessAsync, due to which the compiler will not
/// go to the while loop to take the user input.
/// 
/// To fix this you will need to add a try catch in the asycn methods.
/// For e.g. is given in ProcessAsyncTryCatch method.
/// This way if error is there, it will shown to user.
/// 
/// 
/// 

var task = ProcessAsync("Hello");


static async Task ProcessAsync(string input)
{
    throw new Exception("The exception is thrown from ProcessAsync()");
    var length = await CalculateLengthAsync(input);
    await PrintAsync(length);
    Console.WriteLine("The process is complete.");
}


Console.WriteLine("Taking User input.");
string userInput;
do
{
    Console.WriteLine("We are inside the loop. \nPlease enter the command.");
    userInput = Console.ReadLine();
} while (userInput != "stop");
Console.WriteLine("Done taking the User input.");


Console.ReadKey();
static async Task<int> CalculateLengthAsync(string input)
{
    Console.WriteLine("Starting the calculation.");
    await Task.Delay(2000);
    return input.Length;
}

static async Task PrintAsync(int result)
{
    Console.WriteLine("Starting the Print Method.");
    await Task.Delay(2000);
    Console.WriteLine("The result is " + result);
}


static async Task ProcessAsyncTryCatch(string input)
{
    try
    {
        var length = await CalculateLengthAsync(input);
        await PrintAsync(length);
        Console.WriteLine("The process is complete.");
    } catch (NullReferenceException ex) 
    { 
        Console.WriteLine(ex.Message); 
    }
}