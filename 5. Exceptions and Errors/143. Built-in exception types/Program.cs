// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

try
{
    Person person = new Person("", -100);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

int[] numbers = new int[] { 1, 2, 3 };
int fourth = numbers[4]; // IndexOutOfRangeException
// If same case as above is for list then
// you will get : ArgumentOutOfRangeException

// Using LINK library to get the first element of the List
List<int> emptyCollection = new List<int>();
int firstUsingLink = emptyCollection.First();
// This will throw InvalidOperationException when collection is empty.
// We can use this InvalidOperationException when we are dealing with arrays
// also. We will throw it manually while dealing with arrays.
// We use InvalidOperationException, when we do something which we should not be
// doing.
// We can also use ArguemntOutOfRangeException here in the place of
// InvalidOperationException for that getting first element part.

Console.ReadKey();

class Person
{
    public string Name { get; }
    public int YearOfBirth { get; }

    public Person(string name, int yearOfBirth)
    {
        if (name is null)
        {
            throw new ArgumentNullException("The name can not be empty"); 
        }
        if (name == string.Empty)
        {
            throw new ArgumentException("Invalid Name.");
        }
        if (yearOfBirth < 1900 || yearOfBirth > DateTime.Now.Year)
        {
            throw new ArgumentOutOfRangeException("Invalid year of birth.");
        }
        Name = name;
        YearOfBirth = yearOfBirth;
    }
}
// We use ArgumentException when argument is not null but is invalid in 
// another way.
// If argument is null then use ArgumentNullException
// If value fo argument is outside of the range of valid values, 
// then use ArgumentOutOfRangeException.
// ArgumentOutOfRangeException is derived from ArgumentException which is derived
// from Exception.
// IndexOutOfRangeException : thrown when index is outside of the lower or upper 
// bounds of an array.
// NotImplementedException :
// Use it in method. When your methods return type is other than void,
// bur for now you do not want add the logic in your method and only want to 
// keep the method signature.
