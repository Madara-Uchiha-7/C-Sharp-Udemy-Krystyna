///
/// When making a public method static may be a good idea.
/// The short answer is: 
/// we can safely make a public method static if we always want to use the same implementation
/// and never replace it with any other.
///
/// 
/// Math class, which implements basic mathematical operations.
/// It has a public static methods.
/// We will never need to switch one implementation of math to another because math is always the same.
/// Also, there is no point in mocking those methods in unit tests.
/// -------------------------------
/// Consider the DateTime.Now property, which returns the current date and time.
/// Let's say we have a method whose job is to format the information about the current day.
/// How can we unit test this method?
/// 
/// If this method runs on Monday, it will give a different result than on Tuesday.
/// To make the test repeatable, we should mock the Now property and set it up to always return the same
/// date.
/// But we cannot mock it because it is static.
/// So it wasn't the best decision from the C# standard library creators to make this property static.
/// They didn't think that someone may need to mock it for testing purposes.
/// 
/// If you wonder how this can be resolved, a common solution is to create a wrapper class implementing
/// our user defined datetime interface.
/// 
interface IDateTime
{
    DateTime Now { get; }
}
class DateTimeWrapper : IDateTime
{
    public DateTime Now
    {
        get
        {
            return DateTime.Now;
        }
    }
}
///
/// These classes job is to provide the same functionality as the wrapped method does, but in a non static
/// way so it can be mocked.
/// There is a special category of C# methods that simply must be made static
/// the extension methods.
/// 
/// Remember, they allow us to seemingly add a method to an existing type without modifying its code.
/// Because they must be made static it is important to make them simple and straightforward.
/// They should never do things like, for example, access some data because since they are static, we
/// will not be able to mock them.
/// 
///