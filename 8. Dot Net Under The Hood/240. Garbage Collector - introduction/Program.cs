// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// Each object in our programs has its lifecycle.
// Once an object is no longer used, it should be removed from the computer's memory so that new objects
// As we mentioned before, this process is quite complex for the objects stored on the heap.
// In .NET, the heaps memory management mechanism is called the Garbage Collector, sometimes abbreviated GC.
// It is one of the critical components of the Common Language Runtime.
// The important thing to understand is that Garbage Collector will not clean the memory immediately.
// We can't deterministically say when exactly that will happen.
// There is a way to force the collection of memory by the Garbage Collector by using the GC.Collect method.
// GC.Collect();
// But this method should almost never be used in production code.
// It is most often used for debugging some issues related to memory consumption.
// There are a couple of situations that trigger the Garbage Collector work.
// Firstly, when the operating system informs the Common Language Runtime that it has little free memory left.
// Secondly, when the amount of memory occupied by objects on the heap surpasses a given threshold. The
// CLR continuously adjusts this threshold as the program runs.
// And thirdly, as mentioned before, when the GC.Collect method is called.
// In this course we focus on single threaded applications. Even if we only want to have one thread by desgin
// it turns out that we have at least two of them because Garbage Collector runs on its own separate thread.
// When the Garbage Collector is triggered to start its work, it may stop all other threads until it finishes.
// The fact that the Garbage Collector may freeze all other threads when it works might obviously cause
// performance issues.
// For example, consider a video game created in C#.
// But it will cause the issue to the user.
// In such cases, it is recommended to avoid frequent triggering of the garbage collector work.
// There are some techniques to do it.
// For example, by using a pool of objects that can be reused instead of frequent creation and destruction of short-lived objects.
// After the Garbage Collector frees the memory occupied by unused objects, it performs memory defragmentation.
