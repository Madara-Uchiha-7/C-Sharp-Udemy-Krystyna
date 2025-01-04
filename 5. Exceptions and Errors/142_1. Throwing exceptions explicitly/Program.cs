try
{
    Person person = new Person("", -100);
}
catch (Exception ex)
{ 
    Console.WriteLine(ex.Message);
}
Console.ReadKey();

class Person
{
    public string Name { get; }
    public int YearOfBirth { get; }

    public Person(string name, int yearOfBirth)
    {
        if (name == string.Empty)
        {
            throw new Exception("Invalid Name.");
        }
        if (yearOfBirth < 1900 || yearOfBirth > DateTime.Now.Year)
        {
            throw new Exception("Invalid year of birth.");
        }
        Name = name;
        YearOfBirth = yearOfBirth;
    }
}
// Make sure to throw the exceptions only when it is imp
// and dev will understand the cause of error.
// The exception should contain the details of error neatly which
// will help the dev what to check.

// We should choose the specific exception
// If not available, then we can create our own.