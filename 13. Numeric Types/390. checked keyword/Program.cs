///
/// We will learn the purpose of the checked keyword.
/// This will teach us how to deal with numeric overflows.
/// 
/// We can use the checked keyword to ensure we will be warned in last lecture situation.
/// 
var twoBillion = 2_000_000_000;

int sumSoFar = 1_900_000_000;
int nextTransaction = 1_000_000_000;

/// The checked keyword defines a scope in which arithmetic operations will be checked for overflow.
/// If an overflow happens, an exception will be thrown.
/// So in this scope, any overflow will cause an exception instead of failing silently.
/// 
checked
{
    if (sumSoFar + nextTransaction > twoBillion)
    {
        Console.WriteLine("Transaction blocked.");
    }
    else
    {
        Console.WriteLine("Transaction executed.");
    }
}
/// You may wonder why aren't exceptions always thrown on numeric overflow?
/// Well, the reason is simple.
/// It's performance.
/// Computers are very good at doing arithmetic operations, and they do them extremely fast.
/// On the other hand, checking for overflow is actually quite a complex operation and it takes some time.
/// If we had a lot of arithmetic operations in this application and we put them all in the checked context,
/// the performance impact could be noticeable.
/// Let's continue the topic of the checked keyword in the following lecture.
/// 