// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

Console.WriteLine("Enter the number: ");
string inputNumberStr = Console.ReadLine();

try
{
    int number = ParseStringToInt(inputNumberStr);
    Console.WriteLine(number);
}
catch
{
    Console.WriteLine("An Exception was thrown");
}
finally
{
    Console.WriteLine("In finally block");
}
Console.ReadKey();

int ParseStringToInt(string inputNumberStr)
{
    try
    {
        return int.Parse(inputNumberStr);
    }
    catch
    {
        Console.WriteLine($"Parsing error " +
            $"in the {nameof(ParseStringToInt)} method.");
        return 0;
    }
}
// There is a method called 
// int.TryParse(stringVariable) : This does not throw the 
// error. If such methods are available then use these methods
// rather than exception, because exceptions complicate the code and
// also have the -ve performece impact.

// In try bock we add the code which may cause the error.
// But we can not predict everything. For e.g.
// OutOfMemoryException, NullReferenceException (accessing the object
// which is null). So we can not keep using try catch blocks for everything.
// This will cause the noice in code and will become hard to understand
// the code.
// Solution is : Use local try blocks when we truly see the risk or an 
// error-causing situation and if we can actually handle it.

// We can define global catch for those errors which may come in
// unpredicted way.

// In try the error is thrown and in catch it is catched and appropriate
// error message is shown. Sometimes DEVs store the message in the DB
// so that they can find out why it came.
// Code in the finally block is executed no matter what.
// It is executed after the compiler runs the try and catch block.
// It is ued to clean up some resources that were used in the try block.
// For e.g. , if you have opened the db connection in the try blcok then
// it is closed in the finally block.
// Finally block is optional.

// We can write the catch block without adding parameters and circular
// brackets to it like we have done in the above code.
// 1st catch after the try is the catch whihc will handle the error 
// first.

// She has done intresting thing the method. 
// Since the method must return the int value, and if error comes then
// instead if returning the value the code goes in catch.
// So sytanx error will come. To handle that she is returning the 
// value from catch. NOTE: this is not the good practice because the 
// 0 will be return even the input string is wrong. If there is specific
// usecase then it is okay or handle it like:
// For e.g. returning the default value
// if the input string is wrong. (Use right name for method in such case
// like ParseStringToIntOrGetDefault())
// She has also used nameof method so that even if the method name
// is changed, then nameof() will rename is automatically and use it as
// stirng.


// Sometimes it is good to show a good message to user and keep the
// application running. For e.g. we can show message called
// "Divide by zero is not allowed"
// Sometimes is it better to stop the application in serious
// scenario.

// We can change the catch block and add a parameter to it 
// to grab the exception, if you want show the exception.

// catch (Exception ex)
//{
//      Console.Log("Exception message is : " + ex.Message);
//      It seems Message is getter here ;)
//}

// catch (Exception ex) : This is a vary general catch block.
// It catches the exceptions of any type.

// We can be more accurate and catch specific exceptions.
