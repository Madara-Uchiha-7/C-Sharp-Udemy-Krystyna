///
/// We will learn about the nullable reference types feature.
/// We will also understand what code review is .When hearing about nullable reference types
/// you might think it is silly.
/// 
/// After all, all reference types are nullable in C#, right?
/// Well, yes, this is true.
/// 
/// And it didn't change with introducing the nullable reference types feature with C# 8.
/// 
/// Before we explain in detail what this feature is about, lets see some code.
/// Let's say we work on an application that manages house-related data.
/// 
/// There are two main types: House and Address that we use all around this app.
/// 
/// The House class has two properties OwnerName and Address. 
/// There is another type or class that is called Address which has another two properties that is String and Number. 
/// We have constructor of these classes which are assigning the values to the properties while creating the object.  
/// Now there is a possibility that while creating the object of these two classes the user enters null value. 
/// So if user enters the null value and in main code logic,  if we are trying to access these class properties or 
/// perform any logic on these class properties then there is a possibility that NullReferenceException will be thrown. 
/// The compiler will show the warning in such cases. 
/// To avoid that we can add Null Checks in the constructors of these two classes. 
/// But problem is if there is any other developer who is working on the main logic method and if he still sees the warning from 
/// the compiler (because adding null checks in the compiler will not remove the warning),
/// then he will add 
/// his own NullChecks in that main code logic which will make whole code huge.
/// Such code sometimes takes a significant part of the entire code base, making it bulky as well as hard
/// to read, maintain and test.
/// 
/// Wouldn't it be just simpler if we could agree that the address and its components cannot be null and
/// that we promise to enforce it at the constructor level?
/// 
/// Well, the need for such an agreement was exactly the reason for introducing nullable reference types.
/// 
/// This feature gives us the ability to declare a reference type as nullable or not
/// nullable.
/// If a type is declared as not nullable
/// the compiler will give us warnings in any context in which there is a risk that the value may actually
/// be null, due this this other developer may add the null checks.
/// This warning comes even if we handle the null checks in the constructor.
/// 
/// If the type is nullable, the compiler will warn us where a null reference exception could happen.
/// 
/// With C# eight and newer
/// the old way of declaring reference types
/// will make them not nullable.
/// 
/// E.g.
/// stirng str = null;
/// The compiler gives us a warning.
/// We declared this variable as a non nullable string, but we assigned null to it.
/// 
/// This doesn't make much sense.
/// Hence the compiler warning.
/// We can fix it by declaring the variable as nullable the same way as we would declare nullable value
/// types:
/// stirng? str = null;
/// Now the warning will go.
/// 
/// This variable is a nullable string, so assigning null to it is fine.
/// 
/// A very important note: the nullable reference types feature does not change anything in how the program
/// is executed.
/// Non nullable values can still hold a value of null.
/// 
/// They will still throw NullReferenceExceptions if they are null and if we call some method or property
/// on them.
/// 
/// This feature only changes how compiler warnings are issued.
/// 
/// 
/// 
///
class House
{
    public string OwnerName { get; }
    public Address Address { get; }

    public House(string ownerName, Address address)
    {
        OwnerName = ownerName;
        Address = address;
    }
}
class Address
{ 
    public string Street { get; }
    public string Number { get; }

    public Address(string street, string number)
    { 
        Street = street; 
        Number = number;
    }
}


///
/// What is the default value for non-nullable reference types?
/// Well, ironically it is null because what else could it be?
/// The great thing about the nullable reference types feature is that it has good support from Visual
/// Studio and other modern IDEs.
/// 
/// A quote what Jon Skeet, a C# authority has once said:
/// "Being able to know when things might or might not be null, even when it is only to 90% confidence is
/// a lot better than 0% confidence."
/// 
/// 