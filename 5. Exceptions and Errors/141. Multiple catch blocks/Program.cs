Console.WriteLine("Enter the number: ");
string inputNumberStr = Console.ReadLine();

try
{
    // For wrong string input the FormatException exception will come
    int number = ParseStringToInt(inputNumberStr);
    // If number is 0 then DivideByZero exception will come.
    // You need to catch this exception also because if there is no
    // global catch then FormatException will not catch this error. 
    int result = 10 / number; 
    Console.WriteLine(number);
}
// We will catch the format exception because that
// is what we are getting. on line 6
catch (FormatException ex)
{
    Console.WriteLine("Wrong Format Input. Input string is not parsable to int: " + ex);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Dividing by 0 is not allowed: " + ex);
}
// After specific exceptions lets add the catch 
// which is global catch in the end, so if any unexpreced exception come then we can 
// grab it. Make sure it is in the end. Because catch blocks catches the erros 
// in linear way, 1st catch will grab it, if does not match then 2nd will do 
// and so on.
catch (Exception ex)
{
    Console.WriteLine("Unexpected error occured: " + ex);
}
finally
{
    Console.WriteLine("In finally block");
}
Console.ReadKey();

int ParseStringToInt(string inputNumberStr)
{
        return int.Parse(inputNumberStr);
    
}

// It is a good thing to catch specific exceptions as possible.
// We can give custom error message like this.

// If you add a global catch block on top, above the specific catch blocks, then code will not compile.