// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

try
{
    int result = GetFirstElement(new int[1] { 1});
    Console.WriteLine(result);
    result = GetFirstElement(new int[0]);
    Console.WriteLine(result);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.ReadKey();

int GetFirstElement(IEnumerable<int> numbers)
{
    // We will assume that list collection contains atleast one
    // collection
    foreach (int number in numbers)
    {
        return number;
    }

    // Since we are returning from the foreach,
    // there is a possibility that this foreach may not run if
    // element does not exist.
    // So, c# does not compile in such scenarios.
    // So, we have return something from the outside of the foreach
    // So, lets return the exception, use "throw"
    // Since Exception is an class and new Exception will create the object.
    // We can save this in the variable and then throw that variable also.
    // But mostly it is done like below.
    throw new Exception("The element can not be Empty.");
    // Now we are returning the exception instead of int, so compiler
    // does not complain now, because we are either returning the int 
    // or exception which we will catch in the catch block.
}


// We have used new int[0]
// I think we create the object of array whose size is 0.
// So means no element in the array.
// but holds no value.
// int[] item = new int[1]{10}; 
// Here new int[1] means array of size one
// Our method GetFirstElement takes the IEnumerable
// means types which can be iterated. So, it takes array whose size is 0.
// I think IEnumerable is interface which is implemented by 
// array, list etc. classes and these classes provide their own
// implementation to iterate over those objects.
// So, I think
// IEnumerable<int> numbers : 
// numbers will point to the -> numbers = new int[0];