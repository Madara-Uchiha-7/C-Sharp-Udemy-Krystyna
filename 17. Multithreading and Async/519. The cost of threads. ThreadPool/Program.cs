// Creating and starting new thread is pretty costly operation from the performance point of view.
// For each thread system has to allocate some memory and the operation of starting this thread 
// by itself takes quit a lot of time. 

using System.Diagnostics;

const int iterations = 100;
Stopwatch stopwatch = Stopwatch.StartNew();
for (int i = 0; i < iterations; i++)
{
    // Last time we passed the lambda to the Thread constructor 
    // but this time we only passed the method name.
    Thread thread = new Thread(PrintA); 
    thread.Start();
}
Console.WriteLine();
stopwatch.Stop();
Console.WriteLine("Took: " + stopwatch.ElapsedMilliseconds);

// You will notice it takes quite a time.
// Now, we know that most of those threads will live for a very short time.
// So, instead of creating new threads all the time, it is better to create the pool of thread.
// E.g.  
// Thread Pool:
// Thread1
// Thread2
// Thread3
// Now, when new work item needs to be scheduled on a thread, we will look into this pool and 
// look for thread that is not currently used.
// We assign that thread to that work item and once that work item completes it execution
// that thread will again go to the Thread Pool.
// We do not need to implement these thread pool by ourselves.
// .NET creators already did it for us, and we can use the ThreadPool class.

Stopwatch stopwatch1 = Stopwatch.StartNew();
for (int i = 0; i < iterations; i++)
{
    // Last time we passed the lambda to the Thread constructor 
    // but this time we only passed the method name.
    ThreadPool.QueueUserWorkItem(PrintA);
    // This expects Object as a parameter to the passed method, so we have 
    // used object obj in the PrintA()
}
Console.WriteLine();
stopwatch1.Stop();
Console.WriteLine("Took: " + stopwatch1.ElapsedMilliseconds);

Console.ReadKey();

static void PrintA(object obj)
{
    Console.Write("A");
}

static void PrintPluses(int n)
{
    Console.WriteLine("\nPrintPluses thread's ID: " + Thread.CurrentThread.ManagedThreadId);
    for (int i = 0; i < n; i++)
    {
        Console.Write("+");
    }
}

// I think since we are creating the new thread inside the for loop,
// and for loop runs of Main thread, so thats why, stopwatch.Stop(); runs after the completion 
// of for loop.

// Thread pool is what we should use.