///
/// We will learn how exceptions are managed when they are thrown on other threads.
/// 
/// We will start with the most basic scenario,
/// when an exception is thrown in a separate thread created and started using the Thread class.
/// But first, let's make sure we remember how exceptions behave in single-threaded applications.
/// If we write 
/// Console.WriteLine("Main thread ID:" + Thread.CurrentThread.ManagedThreadId);
/// throw new Exception("Some error message.");
/// We will see that the application simply crashes.
/// 
/// This exception is not handled in any way, so closing the app is the only thing that can happen.
/// 
/// Of course, if we wrap 
/// throw new Exception("Some error message.");
/// line into try-catch block, we could catch and handle this exception,
/// preventing the application from crashing.
/// 
/// But now let's see what happens if the exception is thrown on a separate thread.
///

Console.WriteLine("Main thread ID:" + Thread.CurrentThread.ManagedThreadId);

Thread thread = new Thread(() => MethodThrowingException());
thread.Start();


Thread.Sleep(1000);
Console.WriteLine("Program is finished.");
Console.ReadKey();

static void MethodThrowingException()
{
    Console.WriteLine("Inside method throwing Exception.");
    throw new Exception("Some error message.");
}

/// You will see that due to line: throw new Exception
/// the application will crash just the same way it did in a single-threaded application.
///
/// So what is the big deal about exception handling and threads?
/// If you wrap the above main calling code like below
///
/*
try
{

    Thread thread = new Thread(() => MethodThrowingException());
    thread.Start();
}
catch (Exception ex)
{ 
    Console.WriteLine(ex.Message); 
}
*/

/// The code will still crash even though there is catch block present.
/// This is because exceptions thrown on one thread can by default, only be caught on the same thread.
/// In this code, the exception is thrown by this new thread: 
/// new Thread(() => MethodThrowingException());
/// yet we try to catch it in the main thread.
/// It doesn't work.
/// 
/// If we really want to catch this exception, we would need to move the try-catch block to MethodThrowingException method,
/// as this is the method that gets executed on the new thread.
/// That is try catch will come inside the MethodThrowingException()
/// 
/// But this is a serious problem.
/// We can't assume we can always add a try-catch block inside any method.
/// What if we didn't define this method, but we took it from some library?
/// Also, we often want to have a single place for catching all unhandled exceptions, usually in the main
/// method or any other entry point of the application.
/// 
/// But this will not work if we use separate threads.
/// Exceptions thrown on other threads will simply remain unhandled, and they will crash our application.
/// 
/// Luckily, when using tasks, not plain threads, we have much more control over exceptions.
/// Let's take a closer look at exceptions thrown in tasks in the following lecture.
///
