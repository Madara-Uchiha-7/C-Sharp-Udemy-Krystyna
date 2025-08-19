// Lets print additional message after starting the thread.

Console.WriteLine("Cores Count: " + Environment.ProcessorCount);
Console.WriteLine("Main thread's ID: " + Thread.CurrentThread.ManagedThreadId);

Thread thread1 = new Thread(() => PrintPluses(200));
Thread thread2 = new Thread(() => PrintMinuses(200));

thread1.Start();
thread2.Start();

// You will mostly see below message is getting printed before even thread1.Start() runs.
// This is because, even though Start method is called, main thread execution continues.
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