/// We will also learn what an AggregateException is.
/// 
/// 


Console.WriteLine("Main thread ID:" + Thread.CurrentThread.ManagedThreadId);

// Dclared the task variable outside the try block so I can access it easily from the code below try catch.
Task task;
try
{
    task = Task.Run(() => MethodThrowingException());
    // task.Wait();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

Thread.Sleep(1000);
Console.WriteLine("Program is finished.");
Console.ReadKey();

static void MethodThrowingException()
{
    Console.WriteLine("Inside method throwing Exception.");
    throw new Exception("Some error message.");
}

// So the exception is thrown, but it is not caught in the catch block, nor does it crash the application.
// In debug mode, if you double click and select taskm you will see status of the task as faulted.
// The status is correctly set and expresses that something went wrong within the code executed in the task.
// Moreover, here we can see the Exception property.
// Which contains the exception thrown by the MethodThrowingException.
// So if we wanted to, we could try to handle the issue within the task by checking if the status is Faulted
// and then performing an appropriate action.
// Of course, we would need to be careful not to do it while the task is still running.
// It would bring quite a lot of complexity.
// Because of that, relying on plain old trycatch blocks may be easier.
// But the problem is we already have a catch block, but it doesn't catch this exception.

// Explicitly wait for this task to be completed using the Wait method.
// You can do so by uncommenting the line : task.Wait();
// And now we will see that the code did enter the catch block.
// But in debug mode if you check ex using quick watch and write ex.GetType(),
// the type of this exception will be AggregateException.
// Now the exception type is AggregateException, not the plain Exception we threw in the method.

// Let's understand how exception management is designed in the Task Parallel Library.
// Suppose an exception is thrown within the code executed by a task.
// In that case, it will only be propagated to the thread that created this task
// if we wait the task completion, for example, by calling the Wait method or by using the Result property.
// If we don't wait for the task completion, the exception will not reach the thread that started the task.
// We will only be able to see that it happened by checking if the task status is Faulted, and that the
// Exceptions property carries an exceptions.
// If we wait for the task completion, the exception thrown within this task code will be wrapped in an
// AggregateException.
// This is because more than one exception can be thrown within a task.
// Also, we can await multiple tasks with one command.
// All those exceptions will be aggregated within this AggregateException.
//
// Change your catch block's parameter
// AggregateException instead of Exception.
// Then while debugging the ex:
// We will see that this AggregateException contains a single exception inside.
// that is InnerExceptions count will be 1.

// But what if we don't want to wait because we want the asynchronous execution of the task?
// 