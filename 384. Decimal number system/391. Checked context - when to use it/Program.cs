///
/// We will discuss when the checked keyword should be used and what the alternatives for
/// it may be.
/// 
/// We said that checking for numeric overflow is not enabled by default as it may degrade the application's
/// performance.
/// 
/// That's why often we don't want to use the checked context.
/// For example, in this case, the issue we originally had was not caused by the lack of the checked context,
/// but by the wrong numeric type we used.
/// 
/// Our application is designed to operate on huge numbers, yet it is using integers, so numbers with quite a limited range.
/// 
/// Soon we will learn about other numeric types so we can always choose the best one for our needs.
/// In this context, we should choose decimal which is the right type for representing money, as it is precise
/// and has a huge range.
/// 
/// Also, even if we want to keep using a numeric type with a smaller range, we have another choice than
/// using the checked context.
/// 
/// We can simply use a larger type only for the sake of the condition check.
/// 
/// Lets see it.
/// 
var twoBillion = 2_000_000_000;

int sumSoFar = 1_900_000_000;
int nextTransaction = 1_000_000_000;

long sumAfterTransaction = (long) sumSoFar + (long) nextTransaction;

if (sumAfterTransaction > twoBillion)
{
    Console.WriteLine("Transaction blocked.");
}
else
{
    Console.WriteLine("Transaction executed.");
}

/// Long has a much wider range than
/// integer, so this operation will not cause an overflow.
/// And actually this code is faster than using the checked context.
/// And additionally we don't need to handle an exception.
/// 
/// So when to use checked?
/// Well, in places where we suspect a numeric overflow and when we want to be sure, it will not happen
/// silently.
/// 
/// But before we define a checked context, we should answer a few questions.
/// Is the numeric type we use correct or should it be changed to something with a larger range?
/// Are we sure that we want to throw and handle an exception or perhaps a simple condition check operating
/// on a larger numeric type will suffice?
/// 
/// And finally, are we sure numeric overflow is a problem in this case?
/// There are some algorithms that don't care about the numeric overflow and they work just as well when
/// it happens and when it does not.
/// If the answer to all those questions is yes, we know using the checked context is a good idea.
/// 
/// 