/// In this video, we will learn how to handle exceptions carried within AggregateException.
/// 

Console.WriteLine("Main thread ID:" + Thread.CurrentThread.ManagedThreadId);

/// The lambda we currently have in faultedTask is very generic, and it doesn't handle different exceptions in different ways.
/// We want to handle all exceptions I suspect may be thrown in this task.
/// We could write some code, checking whether any of the exceptions carried by AggregateException is argument
/// null or divide by zero, but there is an easier way.
/// The AggregateException exposes a special method called Handle.
/// This method needs a function that can take an exception and return a bool.
/// aultedTask.Exception.Handle(ex=> lambda will be applied to all exceptions carried by the AggregateException.
/// If we know how to handle a specific exception type, we should do it and then return true to indicate
/// that the exception was successfully handled.
/// If not, we should return false to show that we didn't handle the exception and it should be rethrown.
/// We will see that the status of this task is RanToCompletion in debug mode.
/// 
Task task = Task.Run(() => Divide(2, null))
    .ContinueWith(
        faultedTask =>
        {
            faultedTask.Exception.Handle(ex =>
            {
                Console.WriteLine("Division task finished.");
                if (ex is ArgumentNullException)
                {
                    Console.WriteLine("Arguments can not be null");
                    return true;
                }
                if (ex is DivideByZeroException)
                {
                    Console.WriteLine("Division by 0 is not allowed.");
                    return true;
                }
                Console.WriteLine("Unexpected exception type.");
                return false;
            });
        },
        TaskContinuationOptions.OnlyOnFaulted 
    );

/// If you forgot to add divide by 0 exception,
/// an exception will be thrown from the Handle method.
/// Remember: the continuation is also a task.
/// So this is just the case when an exception is thrown within a task.
/// In this code, we don't wait for the continuation task completion, so the program will not crash and
/// the status of this task will become Faulted.
Task task1 = Task.Run(() => Divide(2, null))
    .ContinueWith(
        faultedTask =>
        {
            faultedTask.Exception.Handle(ex =>
            {
                Console.WriteLine("Division task finished.");
                if (ex is ArgumentNullException)
                {
                    Console.WriteLine("Arguments can not be null");
                    return true;
                }
                /*if (ex is DivideByZeroException)
                {
                    Console.WriteLine("Division by 0 is not allowed.");
                    return true;
                }*/
                Console.WriteLine("Unexpected exception type.");
                return false;
            });
        },
        TaskContinuationOptions.OnlyOnFaulted
    );

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

