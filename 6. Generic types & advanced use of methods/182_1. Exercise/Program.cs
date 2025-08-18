// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

/*
Type constraints & IComparable - SortedList of FullNames
Finalize the implementation of the given program.

The SortedList is a wrapper for a collection. 
It sorts the collection given in the constructor using the Sort method.

The FullName class holds two string properties - FirstName and LastName.

We want to be able to create a SortedList<FullName> object. 
The names stored in the Items collection should be sorted first by LastName, then by FirstName.

For example, for the following collection of FullNames passed as the constructor argument:
John Smith, Anna Smith, Kenji Narasaki, John Watson

The Items collection of the SortedList should contain FullNames objects in the following order:
Kenji Narasaki, Anna Smith, John Smith, John Watson
Kenji Narasaki is first because his last name is first in alphabetical order. 
Two people with the same last name (John Smith and Anna Smith) are ordered by their first names. 
The last in the order is John Watson because his last name is last in alphabetical order.

You will need to:

Specify a proper type constraint in the SortedList class. 
Only classes that can be ordered should be used as the T parameter.

Make FullName class implement a proper interface that will allow the ordering of objects of this class.
*/

/*SortedList<FullName> sortedFullNames = new SortedList<FullName>();*/

// John Smith, Anna Smith, Kenji Narasaki, John Watson
FullName johnSmith = new FullName 
{ 
    FirstName = "John", LastName = "Smith" 
};
FullName annaSmith = new FullName
{
    FirstName = "Anna",
    LastName = "Smith"
};
FullName kenjiNarasaki = new FullName
{
    FirstName = "Kenji",
    LastName = "Narasaki"
};
FullName johnWatson = new FullName
{
    FirstName = "John",
    LastName = "Watson"
};
List<FullName> fullNames = new List<FullName>()
{
    johnSmith,
    annaSmith,
    kenjiNarasaki,
    johnWatson
};
SortedList<FullName> sortedFullNames = new SortedList<FullName>(fullNames);
public class SortedList<T> where T : IComparable<T>//your code goes here 
{
    public IEnumerable<T> Items { get; }
     
    public SortedList(IEnumerable<T> items)
    {
        var asList = items.ToList();
        asList.Sort();
        Items = asList;
    }
}

public class FullName : IComparable<FullName> // your code goes here
{
    public string FirstName { get; init; }
    public string LastName { get; init; }

    public override string ToString() => $"{FirstName} {LastName}";

    //your code hoes here
    public int CompareTo(FullName fullName)
    {
        int lastNameComparisonResult = LastName.CompareTo(fullName.LastName);
        if (lastNameComparisonResult != 0)
        {
            return lastNameComparisonResult;
        }
        else return FirstName.CompareTo(fullName.FirstName);

    }
}
