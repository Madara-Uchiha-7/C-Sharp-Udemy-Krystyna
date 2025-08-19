///
/// Concurrency:
/// 2 or more tasks can start, run and complete in overlapping time periods.
/// It does not necessarily mean that they must run exactly at the same time.
/// Concurrency can also happen on single core processor. 
/// 2 independent tasks can be started at the same moment of time. The processor will
/// handle them both, thanks to the time slicing we learned before.
/// For user it make seem that both the tasks are executed at the same time.
/// Parallelism:
/// Multiple tasks runs truly at the same time. 
///