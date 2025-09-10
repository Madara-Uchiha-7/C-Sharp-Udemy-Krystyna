// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// Dont go on changing the types randomly
// for e.g. from class to struct because there is a possibility that once object of class has more than one reference variables.
// Means class A has a varibale A and reference variable A_1, co changing the values using the A_1 is changing the value of A.
// Making class struct will stop this behaviour. So it is risky to go on changing the types.
// It is possible that you are sending the object of the class as the argument because that method parameter is also of the obejct type.
// So, dont changes the method parameter types also, like making the parameter class to struct.
// We can prohibit any modifications of some type, not only when it is passed as a parameter, by making
// this type immutable.
// Once a variable of an immutable type is created, it can never be modified.
// If we need to modify it, we need to perform a non-destructive mutation, which means we will simply
// create a copy of this object with one or more properties set to new values.
// Creating immutable types is simple. We must make all their fields and properties init-only.
// So once the object is created, it cannot be modified.
// For example, if we wanted to make the person class immutable, we would need to change those set accessors 
// Old:
/*class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
*/
// New:
class Person
{
    public string Name { get; init; }
    public int Age { get; init; }
}
// So, below will now not work :
// void AddOnePersonAge(Person person)
// {
//    ++person.Age++;
// }
// To make it work, you need to create a copy i.e. new object
/*Person AddOnePersonAge(Person person)
{
   return new Person() { Name = person.Name, Age = person.Age + 1};
}*/

// By the way, using immutable types and specifically having methods that never modify the input parameters
// is one of the rules in functional programming, a coding paradigm that has become more and more popular.
