///
/// Let's now learn about the most important synchronization mechanism: the lock.
/// We'll see how to use it to prevent two threads from accessing some shared resources at the same time.
/// 
/// We will also understand what a critical section is.
///
/// The critical section is the segment of code where multiple threads or processes access shared resources,
/// such as common variables and files, and perform write operations on them.
/// We can limit the access to the critical section to one thread at a time by using a lock.
/// Here, critical section is Value++ and Value--;
///

Counter counter = new Counter();

List<Task> tasks = new List<Task>();

for (int i = 0; i < 10; i++)
{
    tasks.Add(Task.Run(() => counter.Increment()));
}
for (int i = 0; i < 10; i++)
{
    tasks.Add(Task.Run(() => counter.Decrement()));
}

Task.WaitAll(tasks.ToArray());

Console.WriteLine("Counter value is : " + counter.Value);
Console.ReadKey();

class Counter
{
    /// <summary>
    /// A private member to the Counter class simply of the object type.
    /// It could be any reference type, but the object is the simplest.
    /// If this lock were of a value type, like for example, an int, this code would not compile.
    /// </summary>
    private object _valueLock = new object();
    public int Value { get; private set; }

    public void Increment()
    {
        /// You can think of this object as a padlock.
        /// When a thread enters this section, it closes this padlock, preventing other threads from entering.
        /// Only after this thread is finished with this code execution does it open the padlock and the next thread
        /// may enter.
        lock (_valueLock)
        {
            Value++;
        }
    }
    public void Decrement()
    {
        lock (_valueLock)
        {
            Value--;
        }
    }
}

/// Just a word of caution: because locks prevent multiple threads from performing some work simultaneously
/// they limit the performance benefit we take from multithreading.
/// That's why it is important to only use lock statements where it is really needed.