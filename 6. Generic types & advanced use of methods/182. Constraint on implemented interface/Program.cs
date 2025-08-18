// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// Test case
// We want the method which takes the two values and prints them in order.
// e.g. Given numbers 10 and 5, it should print "5 10" on console.
// But it should work with any type, even if the type is our defined like Person.
// Issue:
// We can not use "if (first > second)" this comparison operator for everything.
// This > operator will work only for those in which it is defined.
// For e.g. there are 2 instances of Person then it will fail at
// printInOrder(person1, person2)
// But we know that IComparable interface allows us to compare the objects also
// if we implement in our class also.
// Lets use it by adding a Type Constraint saying that T can only be a type
// implementing the IComparable interface for method printInOrder().
// And now instead of "if (first > second)" we can use CompareTo()

Person john = new Person { Name = "John", YearOfBirth = 1980 };
Person anna = new Person { Name = "Anna", YearOfBirth = 1815 };
printInOrder(10, 5);
printInOrder("aaa", "bb");
// To make below line work:
// public class Person : IComparable<Person> and  public int CompareTo(Person person)
// is must. This solves our last lecture question for list which we wrote under
// I think section.
printInOrder(anna, john);
void printInOrder<T> (T first, T second) where T : IComparable<T> 
{
    if (first.CompareTo(second) > 0)
    {
        Console.WriteLine($"{second} {first}");
    }
    else
    {
        Console.WriteLine($"{first} {second}");
    }
}

public class Person : IComparable<Person>
{
    public string Name { get; init; }
    public int YearOfBirth { get; init; }

    public override string ToString() => $"{Name} born in {YearOfBirth}";

    public int CompareTo(Person person)
    {
        if (YearOfBirth < person.YearOfBirth)
        {
            return 1;
        }
        else if (YearOfBirth > person.YearOfBirth)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}

/// printInOrder(anna, john);
/// This above method can only be used by the 
/// Takes anna and john. Both are objects.
/// Since, printInOrder uses CompareTo(),
/// when we do first.CompareTo(second):
/// first is the object of Person which implements IComparable,
/// So, logic of Person's CompareTo() will be used.
///