///
/// 
/// The most common use case for this loop is to execute some code a given number of times.
/// 
///

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Hiiii {i + 1}");
}

///
/// When defining a for loop, we must specify three sections.
/// The first one is the initializer section.
/// It is executed only once before entering the loop.
/// In this section we declare and initialize a local loop variable.
/// In our example we declared an integer and initialized it with a value of zero.
/// The declared variable can't be accessed from outside the for loop.
/// Technically we could also use an existing variable here, but it is very uncommon.
/// 
/// Please notice that the loop variable does not need to be an int.
/// It can be a different numeric type a string or anything else.
/// In practice, the vast majority of for loops have the loop variable of type int.
/// 
/// 
/// The next section is the condition section.
/// It determines if the next iteration of the loop should be executed.
/// If it evaluates to true, it will be.
/// Otherwise the loop is exited.
/// The condition section must be a boolean expression.
/// In our example we continue executing the loop as long as the loop variable "i" is smaller than five.
/// 
/// The last section is the iterator section.
/// It defines what happens after each execution of the body of the loop.
/// Most typically we raise the loop variable by one, but we could also reduce it or do anything else with 
/// it.
/// 
/// 
/// 
/// 
///