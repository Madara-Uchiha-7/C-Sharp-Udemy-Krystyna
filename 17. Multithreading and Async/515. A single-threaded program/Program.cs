// Basic Synchronous set up:
Console.WriteLine("Basic Synchronous set up:");
PrintPluses(30);
PrintMinuses(30);
static void PrintPluses (int n)
{
    for (int i = 0; i < n ; i++)
    {
        Console.Write("+");
    }
}

static void PrintMinuses(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write("-");
    }
}
///
/// The above program runs as the single process:
/// It creates a single main thread.
/// The thread will execute a sequence of 2 instructions.
/// 1. PrintPluses(30);
/// 2. PrintMinuses(30);
/// 2 will start only when 1 is finished.
/// This only thread in this program will be processed in one or more 
/// time slices by any core of my laptop's processor.
/// This work will be processed by only one core.
/// This is all right in this case but in some programs this could be 
/// considered as an area of improvement.
/// If program does many independent tasks, it may work faster if many cores
/// work on them in parallel.
/// If you want to check how many cores you have available,
/// you can check it by using Environment.ProcessorCount property:
/// Console.WriteLine(Environment.ProcessorCount);
/// Note :
/// This property returns the number of logical processors 
/// available on the system. This includes both Physical CPU cores
/// and Virtual Cores, which may be created if your supports hyperthreading.
/// Each thread has its unique ID.
/// We can print the ID of the main thread of this application.
/// Console.WriteLine(Thread.CurrentThread.ManagedThreadId)
/// CurrentThread is a static Thread property from Thread class.
/// We can also see all the threads during debugging by using the threads 
/// window.
/// We can open while debugging by clicking on debug -> Windows -> Threads.
/// Threads are only shown if we are stopped at a breakpoint.
/// For e.g. you can add the breakpoint to Console.ReadKey();
/// i.e. at the end.
/// You amy see many threads there, dont worry about it, most of them will be 
/// related to debugger itself.
/// Also .NET runtime creates some special threads under the hood.
/// e.g. thread on which the garbage collector runs.
///
Console.WriteLine();
