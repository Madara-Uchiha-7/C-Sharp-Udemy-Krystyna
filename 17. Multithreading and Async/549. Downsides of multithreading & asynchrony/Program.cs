///
///
/// Synchronous, single-threaded code is simple to understand, debug and test.
/// The execution is performed line by line, making it easy to follow.
/// This is not the case for multithreading and asynchrony.
/// With multithreading, many pieces of code may be executed simultaneously.
/// With asynchrony, the execution may jump from line to line.
/// As a result, such code is often hard to understand and follow.
/// If we encounter a problem, it may be hard to identify not only because of the code complexity, but
/// also because debugging is harder, especially when more than one thread is involved.
/// Testing is also more challenging.
/// When writing tests we want predictable behavior and results, which are hard to achieve with multiple threads.
/// It may happen that in a tested code, some flow is executed in 99% of the cases, but in 1% it is slightly different.
/// 
/// Even if the code gives correct results, the test must be ready for such variation in the flow.
/// Such non-deterministic code behavior may be a nightmare when dealing with bugs.
/// 
/// What if user got wrong result and now you are unable to reproduce it even if you performed the same steps 
/// as the user.
/// Maybe the user had bad luck and the threads ran in a slightly different order than they usually do.
/// Maybe they have a different configuration of CPUs and can use more or fewer threads than you can.
/// In any case, figuring out what went wrong may be very tricky.
/// Even when we find the issue, which most likely will be some race condition, the fix will probably
/// involve using some synchronization mechanisms like locks, and they will make the code even more complex.
/// 
/// So what should we do with all those problems?
/// Use them when it is really needed.
/// And this especially regards multithreading.
/// If adding multiple threads will make your already fast up 5% faster, it is simply not worth the trouble.
/// 
/// Only do it if it will make a real difference for the user.
/// 
/// And the usage of multiple threads only to the performance critical parts of code where the gain will be the largest.
/// 
/// Try to keep the code using multithreading isolated from other parts of the code, and as simple as it can be.
/// This will help you when investigating issues.
/// 
/// Also, before you add more threads, investigate if other performance optimizations can be added first.
/// If your code is terribly suboptimal, adding even a thousand threads will not make it fast.
/// 
/// In teacher's career, she often worked on performance optimizations, and many times she made some code run hundreds
/// or thousands times faster than before. In none of those cases, she used multithreading to achieve it.
///  
/// Asynchrony is much less dangerous than multithreading, but still there is no need to add it everywhere.
/// Use it when it really makes a difference.
/// 
/// 
/// 
///