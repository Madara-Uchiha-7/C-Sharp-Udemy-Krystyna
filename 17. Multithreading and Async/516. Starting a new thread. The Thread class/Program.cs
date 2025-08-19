///
/// We will see:
/// 1. How to start a new thread using Thread class.
/// 2. The difference between foreground and background threads.
/// 
/// What we want to achieve, 
/// To run 
/// PrintPluses(30) and PrintMinuses(30) on it's own thread outside the 
/// main thread. We want to make them run simultaneously. 
/// 
///
Console.WriteLine("Cores Count: " + Environment.ProcessorCount);
Console.WriteLine("Main thread's ID: " + Thread.CurrentThread.ManagedThreadId);

// As a constructor parameter we have passed a lambda that want to be 
// executed on this thread.
// This below 2 lines will create the thread object. But has not yet
// started it.
Thread thread1 = new Thread(() => PrintPluses(200));
Thread thread2 = new Thread(() => PrintMinuses(200));

thread1.Start();
thread2.Start();
// After above 2 lines you will still see all the + getting printed 
// before -.
// This is because thread1 prints all the + fast before thread2.Start() runs.
// So older was : new Thread(() => PrintPluses(30));
// Lets give 200 in place of 30.

Console.ReadKey();
static void PrintPluses(int n)
{
    Console.WriteLine("\nPrintPluses thread's ID: " + Thread.CurrentThread.ManagedThreadId);
    for (int i = 0; i < n; i++)
    {
        Console.Write("+");
    }
}

static void PrintMinuses(int n)
{
    Console.WriteLine("\nPrintMinuses thread's ID: " + Thread.CurrentThread.ManagedThreadId);
    for (int i = 0; i < n; i++)
    {
        Console.Write("-");
    }
}


// In this application all the threads are foreground threads.
// The other type is Background threads. 
// The background threads does not keep the application running, even if they are still executing.
// While as, as long as foreground thread runs, application runs.
// We can use IsBackground property of thread object to get or set its type.
// E.g.
// Console.WriteLine(thread1.IsBackground);
// thread1.IsBackGround = true;