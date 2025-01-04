///
/// In last lecture we saw that using Type constraint we can now only pass 
/// types which has the parameterless constraints.
/// But for now there no option available to do so for other types of constructors
/// with Type Constraints. For e.g. limiting for the types with the constructor which has 
/// 2 parameters.
/// But there are other use cases of Type Constraints also. E.g.
/// We can decide to only let the types derived from a specific base class to be 
/// used as the type argument.
///

List<Person> people = new List<Person>()
{
    new Person {Name = "John", YearOfBirth = 1980},
    new Person {Name = "Anna", YearOfBirth = 1815},
    new Person {Name = "Bill", YearOfBirth = 2150},
};

List<Employee> employees = new List<Employee>()
{
    new Employee {Name = "John", YearOfBirth = 1980},
    new Employee {Name = "Anna", YearOfBirth = 1815},
    new Employee {Name = "Bill", YearOfBirth = 2150},
};
IEnumerable<Person> validPeople = GetOnlyValid(people);
IEnumerable<Person> validEmployee = GetOnlyValid(employees);

foreach (Person employee in validEmployee)
{
    ((Employee)employee).GoToWork();
}

IEnumerable<Person> validPeopleGeneric = GetOnlyValidGeneric(people);
IEnumerable<Employee> validEmployeeGeneric = GetOnlyValidGeneric(employees);

foreach (Employee employee in validEmployee)
{
    employee.GoToWork();
}


Console.ReadKey();

IEnumerable<Person> GetOnlyValid(IEnumerable<Person> persons)
{
    List<Person> result = new List<Person>();

    foreach (Person person in persons)
    {
        if (person.YearOfBirth > 1900 && person.YearOfBirth < DateTime.Now.Year)
        {
            result.Add(person);
        }
    }
    return result;
}

IEnumerable<TPerson> GetOnlyValidGeneric<TPerson>(IEnumerable<TPerson> persons)
    where TPerson : Person
{
    List<TPerson> result = new List<TPerson>();

    foreach (TPerson person in persons)
    {
        if (person.YearOfBirth > 1900 && person.YearOfBirth < DateTime.Now.Year)
        {
            result.Add(person);
        }
    }
    return result;
}

public class Person
{
    public string Name { get; init; }
    public int YearOfBirth { get; init; }
}
public class Employee : Person
{
    public void GoToWork() => Console.WriteLine("Going to Work!!!");
}

// We want to create the method using Type Constraint
// which takes the collection of People
// and filter out the people with invalid ages.
// If 1900 > date > current year then filter.
// But why we need a Type Constraint for this, is is not possible using 
// polymorphism. Since the Employee already extends Person.
// Lets see the method GetOnlyValid() for this.
// It returns the IEnumerable of Person but it works for both 
// Person and Employee, because Employee extends the Person.
// But what if
// we want to iterate the collection of valid employees and on each of them call
// GoToWork().
// So below will not work: 
/*foreach (Person employee in validEmployee)
{
    employee.GoToWork();
}*/
// Because validEmployee is collection of people even though it is pointing to the 
// child i.e. Employee object. To Make it work we have to cast it to Employee object.
// Like we have done on the top of the foreach to show this.
// But this is not vary convenient.
// Casting clouds our code (We have to cast each time making it more hard to read)
// and also it costs performance.

// So lets solve this using Generic type constraints.
// We will declare it as it takes a collection of any type but only if this type is
// derived from the Person class.
// GetOnlyValidGeneric will return the collection of Employee or Person 
// accordingly not only collection of People like before.
// Now we can use the foreach without casting.

// Use Type Constraint only if needed. Otherwise go with the Polymorphism way.