///
/// A process is an executing instance of a program that contains its own memory space and resources,
/// operating independently of other processes.
/// On windows we can see the list of runnning processes by opening the task manager. 
/// If there are multiple tabs of browser open then in Task Manager you can open the or extend the Chrome Browser,
/// those are processes. You can say this as many processes are running with in this Chrome Browser program.
/// I.e. In chrome browser program there are multiple processes present representing each tab...I Guess.
/// 
/// Thread is an execution unit within a process.
/// A process can be composed of multiple threads. 
/// Until now, we have only developed programs that, by design, had only one process and thread running within it. 
/// Still another thread lurked in the background called Grabage Collector Thread.
/// Which is created for us by .NET Runtime.
/// You can think of thread as a worker that has given some job.
/// So threads are more lightweight than processes.
/// Threads take less time to be started or terminated.
/// Processes are mostly isolated from each other. While threads running within the same process 
/// share some data.
/// In .NET applications each thread has its own private stack, but they all access the same heap.
/// This is the reason why having multiple threads in a program may be tricky. 
/// For e.g., one thread may try to access some data while another is deleting it.
/// 
/// So, multithreading is capability of the program to execute multiple threads. Which allows us to use 
/// system resources more efficiently. 
/// These multiple threads can be run on mutiple cores simultaneously, speeding the application up.
/// They run concurrently or parallelly.
///