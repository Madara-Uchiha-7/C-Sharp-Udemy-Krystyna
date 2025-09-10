///
/// We have already learned what atomic operations are and that incrementing a value is not atomic.
/// 
/// Let's now consider the following scenario.
/// We have an integer variable called x currently holding zero, and we have two threads trying to increment
/// it at almost the same time.
/// 
/// Since we have two increment operations, the final value should be two, but it won't necessarily be.
/// Let's see why.
/// 
/// Remember, the first step of incrementation is calculating a temporary variable equal to x+1.
/// This is what the first thread does, and it remembers the temporary variable to be one.
/// The second step would be to assign this temporary variable to x.
/// 
/// But what if the second thread performs its first step before this happens?
/// The first thread is in the middle of incrementing the x, but the x value has not yet been increased,
/// so it is still zero and temp = x + 1; is the value the second thread reads.
/// 
/// At this moment, the second thread calculates its temporary variable and it sets it to one.
/// 
/// For each of those threads
/// the next step is to assign the value of the temporary variable to x.
/// 
/// Let's say the first thread does it first, so it assigns one to X.
/// Then the second thread performs this step and it also assigns one to x.
/// 
/// Now their work is done, but the value is wrong.
/// It should be 2 but it is now 1.
/// 
/// The reason for that was that one thread read the value when the other thread was still working on incrementing
/// it.
/// 
/// Such a problem is called a race condition.
/// 
/// A race condition is a situation in concurrent programming where the outcome of a program depends on
/// the timing of events.
/// 
/// It occurs when multiple threads access shared data or resources, and the final outcome is dependent
/// on the order of execution.
/// 
/// Race condition is one of the biggest risks of using multithreading.
/// 
/// It is exceptionally challenging because of its non-deterministic nature.
/// 
/// The program may give correct results
/// in 99% of the cases. Still in 1%, the threads execute in a slightly different order, resulting in the
/// wrong output.
/// 
/// Debugging and reproducing such issues may be very hard.
/// 
/// That's why when designing code in which many threads operate on the same data, we must be careful and
/// use the synchronization mechanisms.
///
///