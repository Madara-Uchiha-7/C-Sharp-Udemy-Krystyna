Console.WriteLine("Cores Count: " + Environment.ProcessorCount);
Console.WriteLine("Main thread's ID: " + Thread.CurrentThread.ManagedThreadId);

/// Task represents the unit of work that can be executed asynchronously on a seperate thread.
/// In other words, it is an operation that can run independently of the main thread.
/// After it is started, main thread continues its work.
Task task1 = new Task(() => PrintPluses(200));
Task task2 = new Task(() => PrintPluses(200));

// We can use below code also: If you use below code then you do not need .Start() method
// This .Run gives same result as .Start(), only difference is, .Run() will save us the addition command to write
// .Start()
// In older code you may see: Task.Factory.StartNew( () => ...);
// It is same as Start() or Run()
//Task task1 = Task.Run(() => PrintPluses(200));
//Task task2 = Task.Run(() => PrintPluses(200));

task1.Start();
task2.Start();  

Console.WriteLine("Program is finished");

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