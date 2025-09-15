///
/// We will discuss some of the drawbacks of using exceptions.
/// While doing so, we'll also learn what goto statement is and why using it is considered a bad idea.
/// We'll see the alternatives for using exceptions and what issues we can have if we decide not to use
/// exceptions at all.
/// 
/// Exceptions impact the performance of the application quite significantly.
/// Of course, only if they are thrown.
/// 
/// If we add a try-catch block, but exceptions are not often thrown in the try
/// the performance will hardly be impacted.
/// 
/// Secondly, and maybe even more importantly, exceptions make the code harder to follow.
/// 
/// When an exception is thrown, the normal execution of the code is disrupted and we suddenly jump to
/// a completely different place in the code, specifically to the first catch block that can handle this
/// exception.
/// 
/// In real-life projects where we sometimes have hundreds of files. So, flow may jump to another file.
/// 
/// The fact that exceptions break the normal execution of a program and make it jump to some other place
/// in the code makes them similar to the infamous goto statement.
/// 
/// When goto is executed, the program jumps to some predefined label.
/// 
///

if (-1 < 0)
{
    goto NavigateNumber;
}
Console.WriteLine("The number is +ve or 0");

NavigateNumber:
Console.WriteLine("The number is negative.");

///
/// Using goto is considered one of the fastest paths to creating spaghetti code.
/// So code that is hard to understand and maintain. Code using goto is extremely hard to follow.
/// But if Goto is bad because it interrupts the normal flow of a program, so are the exceptions because
/// they do the same thing.
/// 
/// Maybe they are even worse because with goto we at least clearly see where we will be taken to. With exceptions,
/// we must figure out by ourselves what catch block will be executed.
/// In our examples it was pretty obvious what catch block will be triggered.
/// But in huge apps where we often have dozens of methods calling one another, it might be complicated.
/// 
/// The last downside of exceptions teacher want to mention is what we discussed in the previous lecture.
/// Exceptions are a side effect of methods and, in a way, a hidden part of their signature.
/// It may make the code harder to understand and maintain.
/// When reading the code, we only see the signatures of the methods we use, and if we don't dive into
/// implementation details, we may make wrong assumptions about how some methods behave and whether or
/// not they throw exceptions.
/// 
/// 
/// In functional programming, which is a programming paradigm that has gathered more and
/// more interest in recent years, instead of throwing an exception, we often opt for returning a composite
/// result from a method.
/// For example, for the method returning the age of an employee, we would not return an integer, but
/// a special type that either carries an integer or information about the error.
/// This way the error becomes the part of the method's result, not a side effect.
/// It is clearly shown in the method signature.
/*
Either<int,Error> CalculateEmployeeAge(Employee employee)
{
    if (employee.YearOfBirth < 1900 || employee.YearOfBirth > DateTime.Now.Year)
    {
        return new Error($"Person's year must be in between 1900 and current year.");
    }
    return DateTime.Now.Year - employee.YearOfBirth;
}
*/
/// This sounds great, but it comes at the cost of code complication because, in this case, we can't operate
/// on the result as we would on a simple int.
/// First, we must check if it carries an int, not an error, and only then we can extract the int value:
///
/*
Either age = CalculateEmployeeAge(1);
if (age.IsError)
{
    Console.WriteLine(...
}
else
{
    Console.WriteLine(...
}
*/
///
/// In all places where we use the calculated age, we'll have to check if it was calculated without error.
/// Even if in 99% of the cases it will be a valid result.
/// So as we can see, such a functional way also has its drawbacks.
/// 
/// But how else can we avoid using exceptions altogether?
/// One could return some special value from a method meant to indicate that the result is wrong, for example,
/// like returnn 999 if age is not in the range instead of returning the Exception.
/// 
/// This is a very bad idea.
/// Imagine we want to calculate the average age of our employees. In a for each loop we calculate the sum
/// of their ages and then divide them by the number of employees.
/// But if some of those values are equal to 999 or -1, the result will obviously be wrong.
/// Such a special result must be handled somehow.
/// 
/// So we see that when it comes to exceptions, being extreme in both using them too much and avoiding them
/// at all costs may cause issues in our code.
/// 
/// Let's move on to the next lecture where we will try to find out if a healthy balance is possible.
/// 
///
