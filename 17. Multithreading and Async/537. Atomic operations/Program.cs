/// In this lecture, we will understand what atomic operations are.
/// In the previous video, we saw an example of code that started to give invalid results once we switched
/// to using multiple threads instead of one. (Using Tasks instead of normal calls to method.)
/// 
/// To see why this happened, we must first understand the concept of atomic operations.
/// An atomic operation is an operation that is indivisible.
/// In other words, it is always performed in one go without a chance of being interrupted.
/// It is composed of a single, very basic step.
/// 
/// For example, assigning one to the x variable is an atomic operation.
/// On the other hand, let's consider the operation of incrementing x by one i.e. x++.
/// It is not atomic because under the hood two steps need to happen.
/// First, the value of x+1 is calculated and assigned to a temporary variable.
/// Then this temporary variable is assigned to x.
/// 
/// 
///