using System.Security.Cryptography;

/// This video will show us how to handle exceptions thrown from tasks asynchronously.
/// We will also learn the purpose of the TaskContinuationOptions enum.
/// 
/// In the previous lecture, we saw that we can catch exceptions thrown by the tasks in a pretty standard
/// way, but we need to explicitly wait for the task completion.
/// We can do it by using the Wait method or accessing the Result property.
/// This isn't great as it blocks the main thread of the app, making the whole thing synchronous.
/// 
/// We would rather have our tasks run asynchronously so we can allow other code to execute while the task
/// is being calculated.
/// 
/// Earlier in the course, we learned how to set up continuations:
/// Tasks that we want to execute after some other task is completed.
/// Thanks to using continuations, we don't block the main thread while the task is being calculated.
/// 
/// As it turns out, we can use the same mechanism for exception handling.
/// 
/// 
Console.WriteLine("Main thread ID:" + Thread.CurrentThread.ManagedThreadId);

// Now, instead of waiting for this task here, I will set up a special continuation that only gets triggered
// once this task finishes its job in a faulted state. So when an exception is thrown within this task.
// 
Task task = Task.Run(() => MethodThrowingException())
    .ContinueWith(
        faultedTask => Console.WriteLine("Exception caught: " + faultedTask.Exception.Message),
        TaskContinuationOptions.OnlyOnFaulted // The crucial element is this argument.
        // It decides that this continuation will only be triggered if a task ends up in a faulted state.
        // Because we use it
        // we are sure that MethodThrowingException() task, which we have accessible  at faultedTask as the lambda argument,
        // will for sure be faulted and its Exception property will not be null.
        // By the way, we can use this TaskContinuationOptions enum in other scenarios too.
        // For example, we may decide that a continuation should only be scheduled if the task has run to completion
        // or it was cancelled using .OnlyOnCanceled or etc. instead of OnlyOnFaulted.
    ); 



Thread.Sleep(1000);
Console.WriteLine("Program is finished.");
Console.ReadKey();

static void MethodThrowingException()
{
    Console.WriteLine("Inside method throwing Exception.");
    throw new Exception("Some error message.");
}

// Remember, faultedTask.Exception is the AggregateException that may carry more than one exception inside.
// We sometimes want to have code that can deal with various exceptions present in the AggregateException.
// Lets see that in next lecture.