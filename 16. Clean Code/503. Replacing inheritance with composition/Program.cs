///
/// We will see how we can refactor the code to use composition rather than inheritance.
/// Lets see the inheritence example then we will convert it into composition.
/// We have a 1 base class and 2 derived classes.
/// Depending on the true or false, respective derived class ReadPeople() method
/// will get executed.
///
/*
bool shallReadFromDatabase = false;
PersonalDataFormatter personalDataFormatter = shallReadFromDatabase ?
    new DatabaseCourcePersonalDataFormatter() :
    new ExcelSourcedPersonalDataFormatter();

Console.ReadKey();
abstract class PersonalDataFormatter
{
    public string Format()
    {
        var people = ReadPeople();
        return string.Join(
            "\n",
            people.Select(p = $"{p.Name} born in "+
            $" {p.Country} on {p.YearOfBirth}"));
    }
    public abstract IEnumerable<Person> ReadPeople();
}

public class Person
{
    public Person(string name, int yearOfBirth, string country)
    {
        Name = name;
        Country = country;
        YearOfBirth = yearOfBirth;
    }

    public string Name { get; }
    public string Country { get; }
    public int YearOfBirth { get; }
}
class DatabaseCourcePersonalDataFormatter : PersonalDataFormatter
{
    public override IEnumerable<Person> ReadPeople()
    {
        Console.WriteLine("Reading from database.");
        return new List<Person>()
        {
            new Person("John", 1982, "USA"),
            new Person("Aja", 1981, "India"),
            new Person("Tom", 1983, "Australia")
        };
    }
}
class ExcelSourcedPersonalDataFormatter : PersonalDataFormatter
{
    public override IEnumerable<Person> ReadPeople()
    {
        Console.WriteLine("Reading from Excel file.");
        return new List<Person>()
        {
            new Person("Martin", 1982, "France"),
            new Person("Aiko", 1995, "Japan"),
            new Person("Selene", 1944, "Great Britain")
        };
    }
}
*/

///
/// Instead of using the abstract method ReadOnly(), we will have a dependency on an object that can provide
/// the data reading functionality.
/// It will implement some IPersonalDataReader interface.
/// Now, let's add a field of this interface type to the PersonalDataFormatter class.
/// private readonly IPersonalDataReader _personalDataReader;
/// This is the very essence of composition.
/// 
/// We will now be able to compose the PersonalDataFormatter with any type implementing
/// the IPersonalDataReader interface.
/// Working together, those types will give us exactly what we want.
/// We will use the dependency injection to provide this object to this class.
/// Now, instead of var people = ReadPeople();
/// we will do : var people = _personalDataReader.ReadPeople()
/// 
/// Now, public abstract IEnumerable<Person> ReadPeople(); is no longer needed.
/// So we will comment it out.
/// 
/// Since PersonalDataFormatter class no longer has abstract methods, we can make it non-abstract.
/// 
/// Now for our derived classes:
/// Instead of making them inherit from the PersonalDataFormatter, we will make them implement
/// the IPersonalDataReader interface.
/// The override keywords are no longer needed.
/// We will also need to rename derived classes. They no longer do the formatting.
/// They only focus on data reading.
/// 
/// The only thing left to do is changing how the PersonalDataFormatter is created.
/// It is a non-abstract type again, so we can simply instantiate it.
bool shallReadFromDatabase = false;

IPersonalDataReader personalDataReader = shallReadFromDatabase ?
    new DatabaseCourcePersonalDataReader() :
    new ExcelSourcedPersonalDataReader();
var personalDataFormatter = new PersonalDataFormatter(personalDataReader);

Console.ReadKey();
/// 
///
interface IPersonalDataReader
{
    IEnumerable<Person> ReadPeople();
}
class PersonalDataFormatter
{
    private readonly IPersonalDataReader _personalDataReader;
    public PersonalDataFormatter(IPersonalDataReader personalDataReader)
    {
        _personalDataReader = personalDataReader; 
    }
    public string Format()
    {
        var people = _personalDataReader.ReadPeople();
        return string.Join(
            "\n",
            people.Select(p => $"{p.Name} born in " +
            $" {p.Country} on {p.YearOfBirth}"));
    }
    // public abstract IEnumerable<Person> ReadPeople();
}

public class Person
{
    public Person(string name, int yearOfBirth, string country)
    {
        Name = name;
        Country = country;
        YearOfBirth = yearOfBirth;
    }

    public string Name { get; }
    public string Country { get; }
    public int YearOfBirth { get; }
}
class DatabaseCourcePersonalDataReader : IPersonalDataReader
{
    public IEnumerable<Person> ReadPeople()
    {
        Console.WriteLine("Reading from database.");
        return new List<Person>()
        {
            new Person("John", 1982, "USA"),
            new Person("Aja", 1981, "India"),
            new Person("Tom", 1983, "Australia")
        };
    }
}
class ExcelSourcedPersonalDataReader : IPersonalDataReader
{
    public IEnumerable<Person> ReadPeople()
    {
        Console.WriteLine("Reading from Excel file.");
        return new List<Person>()
        {
            new Person("Martin", 1982, "France"),
            new Person("Aiko", 1995, "Japan"),
            new Person("Selene", 1944, "Great Britain")
        };
    }
}


// Let's understand the benefits of this change in the following lecture.