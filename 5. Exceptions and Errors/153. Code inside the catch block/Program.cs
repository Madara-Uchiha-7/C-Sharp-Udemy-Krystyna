///
/// We will discuss what code we should and what we should not put into the catch block.
/// We will also understand what happens if an exception is thrown from a catch block.
/// Finally, we will see nested try-catch blocks.
/// 
/// We learned before that if an exception is thrown in the code inside a try block, it will be caught
/// in a catch block if the exception is of a matching type.
/// But here is a tricky question: What would happen if the code in the catch block throws an exception?
/// Well, the short answer is: nothing good.
/// A common misconception is that such an exception might be caught in the next catch block.
/// For e.g.
/// We are creating the error at : int.Parse("hello world");
/// Which is inside the catch block. So, since there is another catch block below, it will not go there
/// even though line : int.Parse("hello world");
/// will cause FormatException which is our next catch block. 
/// This is because catch (FormatException ex) only follows the try.
///
try
{
    int number = int.Parse("0");
    var result = 10 / number;
    Console.WriteLine($"10 / {number} is " + result);
}
catch(DivideByZeroException ex)
{
    int.Parse("hello world");
    Console.WriteLine("Division by 0 is not allowed: " + ex.Message);
}

catch (FormatException ex)
{
    Console.WriteLine("Wrong input, please provide the integer: " + ex.Message);
}
Console.ReadKey();

///
/// Generally it is a bad practice to put any code that can possibly throw an exception inside a catch block.
/// The catch block should be simple.
/// It may return some default value if this is how the method is designed, or print something to the console,
/// log an error in some file or show some pop up to the user.
/// Of course, even such simple operations may fail.
/// For example, the file used for logging errors might for some reason be unavailable.
/// In this case, such an exception thrown from the catch block may go simply go unhandled.
/// It is bad, but it is not a disaster.
/// Remember the global try catch block that we have learned about in the previous lecture?
/// It will catch all exceptions, not caught elsewhere.
/// Still, the global try-catch block should be the last resort of error handling.
/// 
/// To handle above catch issue,
/// we can put try catch inside the catch and put the line : int.Parse("hello world");
/// in the try. But this is not advisable.
///