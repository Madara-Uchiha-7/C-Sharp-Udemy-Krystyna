///
/// Asynchrony:
/// Refers to the occurrence of events independent of the main program flow.
/// These Asynchronous actions are executed in a non-blocking way, allowing the main program flow 
/// to continue processing.
/// Assume we need to take a data from one factory which takes around 10 seconds.
/// Its a bad idea to let other parts of application froze till this happen. To make other 
/// actions still keep going in this 10 seconds is possible using Asynchrony.
/// If that 10 Seconds data is completed then we can perform actions related to that, 
/// like show to user or download it.
/// Synchrony:
/// The process runs only as a result of some other process being completed.
/// 
/// Synchronous:
/// You make a toast on pan. 
/// Once toast is ready only then you make a coffee.
/// 
/// Ansynchronous single threaded:
/// You make a toast on pan.
/// Till pan does its job, you create a coffee.
/// 
/// Asynchronous multi threaded:
/// You hire 2 workers.
/// One make toast and other makes coffee.
///