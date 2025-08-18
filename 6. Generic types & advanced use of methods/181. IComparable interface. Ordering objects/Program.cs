// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// IComparable interface provides a way to compare two objects for sorting 
// purposes.
// We can use .Sort() method on List object, for e.g. list of strings or int.
// It won't work if the list holds our custom class object like person.
// E.g. :
/*
List<Person> people = new List<Person>()
{
    new Person {Name = "John", YearOfBirth = 1980},
    new Person {Name = "Anna", YearOfBirth = 1815},
    new Person {Name = "Bill", YearOfBirth = 2150},
};*/
// Error will be : At least one object must implement IComparable
// This interface contains single method called CompareTo which takes the 
// object as the parameter and returns the integer. If positive then current object 
// will follow the object given as a parameter in sorting order.
// e.g. 2.CompareTo(1); "bbb".CompareTo("aaa"); --> Returns 1
// Since it is +ve it will be considered larger.
// If -ve is returned, it will be opposite.
// e.g. 1.CompareTo(2); "aaa".CompareTo("bbb"); --> Returns -1
// Current object proceedes the object given as the parameter in sorting order.
// Since it is -ve it will be considered smaller.
// If 0 is returned then it means they have the same sorting order.
// Lets implement the IComparable interface for Person class.

using System;

List<Person> people = new List<Person>()
{
    new Person {Name = "John", YearOfBirth = 1980},
    new Person {Name = "Anna", YearOfBirth = 1815},
    new Person {Name = "Bill", YearOfBirth = 2150},
};
people.Sort(); // This works because we have implemented the IComparable for Person.
Console.ReadKey();

// Since the IComparable interface is generic, we passed the Person to it.
public class Person : IComparable<Person>
{
    public string Name { get; init; }
    public int YearOfBirth { get; init; }

    // We will sort it Person so, younger will be on left and older on the right. 
    public int CompareTo(Person person)
    {
        // 1951.CompareTo(1975)
        // Since 1951 is older (lesser than 1975)
        // we will return one because we want 1951 to go to right.
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

        // If you generate CompareTo() using the VS help then you will get below 
        // line automatically.
        // throw new NotImplementedException();
    }
}

// If two people are born in same year then they could be placed in any year.

///
/// I think:
/// Sort is the method of List class. 
/// Which uses the Type which we pass to the List since it is generic.
/// Using that type it goes to that type and check if that type has implemented
/// IComparable or not. If not it throws the error. Since the int, string, .. etc.
/// have implemented the IComparable, it works but for our Person class we had to 
/// add the logic for IComparable CompareTo().
/// Question is how List's sort is allowed to look into different type's CompareTo().
/// I think List has Generic method called Sort which takes the type which is 
/// used with the List and then calls the CompareTo() for each instance of that type
/// one by one. Check List's Sort() definition. 
///