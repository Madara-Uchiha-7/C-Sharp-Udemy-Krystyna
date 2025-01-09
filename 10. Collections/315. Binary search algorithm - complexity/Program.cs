///
/// If the input collection has the 100 size then 
/// after the first iteration the size will br 50
/// then 25, then 12, then 6, then 3 and then 1.
/// This gives the 7 iterations of the loop.
/// For the size of 1000, it will be 10 iterations.
/// So even if 1000 is 10 times larger than 100, still it onlt needs 
/// 3 more iterations.
/// 
/// So, what mathematical function that describes how the number of iterations
/// changes with the input length.
/// It is the logarithm with the base 2.
/// Ceiling(log2(100)) = 7. Ceiling(log2(1000) = 10.
/// Thats why we say that binary search has logarithmic complexity.
/// 
/// Remeber, the logarithm for a certain base is the power to which a base 
/// needs to be raised to reach a given number.
/// e.g. 
/// Here B and 2 are below
/// logB(X) = Y when B^Y = X
/// log2(8) = 3 because 2^3 = 8
/// 
/// Please note that when we are talking about logarithmic complexity, we 
/// don't care about the base.
/// So only write O(logN) not like O(log2N) or O(log3N).
/// In case of binary search the base is 2.
/// 
/// This is the same case for linear complexity like we discussed. That is:
/// The number of operations does not matter, so we write
/// O(N) not O(1N) or O(3N) etc.
/// We only care about the nature of the function i.e. if it is a quadratic or
/// logarithmic and so on.
/// 
/// O(logN) is common for algorithms based on dividing the input size in half
/// for each iteration.
/// 
/// If you see the graph for O(logN) you will see Y grows vary slowly with the growing X.
/// 
///