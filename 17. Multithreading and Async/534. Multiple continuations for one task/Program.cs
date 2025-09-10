/// Let's now discuss how we can set up multiple continuations for a single task.
/// We learned how to set up continuations that will only be triggered if the task is folded.
/// But what if we want to set up one continuation, if the task is faulted and another one if it is successful?
/// Instead of using the Task Run method, we will split the task creation and task starting into two steps.
/// 

Task task = new Task(() => Divide(2, null));
task.ContinueWith(
        faultedTask =>
        Console.WriteLine("Success"),
        TaskContinuationOptions.OnlyOnRanToCompletion
    );
task.ContinueWith(
        faultedTask =>
        Console.WriteLine("Exception thrown: " + faultedTask.Exception.Message),
        TaskContinuationOptions.OnlyOnFaulted
    );

task.Start();
/// Above, for ContinueWith,
/// You may wonder why we didn't use the chaining of continuations here.
/// For e.g. like below:
/// 
/*task.ContinueWith(
faultedTask =>
Console.WriteLine("Success"),
        TaskContinuationOptions.OnlyOnRanToCompletion
    ).ContinueWith(
        faultedTask =>
        Console.WriteLine("Exception thrown: " + faultedTask.Exception.Message),
        TaskContinuationOptions.OnlyOnFaulted
    );
*/
/// It will not work because the last ContinueWith will be dependent on the task created in above ContinueWith
/// which is the task of printing the message about success.
/// 
/// By the way, you can see this code causes warnings:
/// Because this call is not awaited execution of the current method continues before the call is completed.
/// Consider applying the await operator to the result of the call.
/// 
/// This warning is related to the topic of the await keyword, which we'll learn about a bit later in the course.

Thread.Sleep(1000);
Console.WriteLine("Program is finished.");
Console.ReadKey();

static float Divide(int? a, int? b)
{
    if (a is null || b is null)
    {
        throw new ArgumentNullException("Argument can not be null.");
    }
    if (b == 0)
    {
        throw new DivideByZeroException("Division by 0 is not allowed.");
    }
    return a.Value / (float)b.Value;
}

