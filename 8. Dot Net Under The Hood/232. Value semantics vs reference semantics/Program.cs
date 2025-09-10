// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// In below example:
// anotherNumber will hold the value of variable number.
// Changing anotherNumber will not change the value of variable number.
// This works this way because integers are value types in C#, and as such they have a value semantics.
// Value semantics is a way of thinking about variables.
// If a type has value semantics, the only way to modify the value of a variable of this type is through the variable itself.
// Value semantics guarantee that the values stored in the variables are independent.
// So, assigning the number to anotherNumber will create a copy of the value.
int number = 5;
int anotherNumber = number;
anotherNumber++;
Console.WriteLine("Number is : " + number);
Console.WriteLine("Another Number is : " + anotherNumber);

// Reference semantics:
// Person is a class and in C# classes have reference semantics.
// Reference semantics means that variables store an identity of some object called a reference.
// We can think of a reference as an address of the object in memory.
// Two variables can hold a reference to the same object.
// So when an object pointed to by the first variable is changed, it also affects the object pointed to
// by the second variable because both of those variables point to the same object in memory.
// The modification of the second variable's value affected the object pointed to by the first variable.
// When we assigned the person to person2, only the copy of the reference is created and it points to the same object in memory.
// This happened below, we assigned person to person2, now any change in person2 will also change the person.
Person person = new Person { Name = "Chinmay", Age = 29};
Person person2 = person;
person2.Name = "Changed Name";
Console.WriteLine(person.Name);
Console.WriteLine(person2.Name);    
Console.ReadKey();

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}


// In C# we distinguish two types of variables: value types with value semantics and reference types
// with reference semantics.