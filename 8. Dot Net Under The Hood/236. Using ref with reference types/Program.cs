// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// List is a class so it is also a reference type.

List<int> list = new List<int> { 1, 2, 3 };

AddOneToList(list);

list.ForEach(x => Console.WriteLine(x));


AddOneToListRef(ref list);
// In debug window, if you check list, you will see it as null due to ref.
Console.ReadKey();

void AddOneToList(List<int> numbers) 
{
    // Now we know that numbers also points to the list. So numbers.Add will add a number in the end of the list.
    // But what if the reference stored in the parameter is overwritten?
    // For example with null. Null actually means a null reference.
    // So it expresses this variable does not point to any object.
    numbers = null;
    // Thoe above limne will not set the list to null but it will keep its values that is 1, 2, 3
    // Let's understand why that is so.
    // Let's say that once this list is created, its address in memory is 12345.
    // As we know, for reference types, a variable stores an address, not the whole object.
    // So now list variable stores the address 12345.
    // Then we pass this variable as an argument.
    // The parameter that we have here will store the copy of this reference. So also 12345.
    // As long as we only added an item to the list stored under numbers reference, it was reflected outside i.e. list variable
    // because numbers parameter points to the same list as list variable.
    // But we changed that when assigning null to this parameter.
    // So now, numbers store null reference i.e. points to the address of null.
    // If we want different behavior, we can use the ref keyword.
    // This is not only rarely used, but is definitely a fishy design.
}

void AddOneToListRef(ref List<int> numbers)
{
    numbers = null;
}