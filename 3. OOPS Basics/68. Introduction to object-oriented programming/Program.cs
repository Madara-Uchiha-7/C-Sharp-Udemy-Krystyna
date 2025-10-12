///
/// We will understand what classes, objects and instances are.
/// Finally, we will learn the benefits of this coding paradigm.
/// 
/// Let's understand what object-oriented programming is.
/// This paradigm, abbreviated as OOP, is focused on the concept of objects containing data and methods.
/// Those objects can model real-world features like a person or an address.
/// We can compose many objects to create complex instances.
/// For example, a person object can have an address object representing the address at which this person
/// lives.
/// e.g 
/// Person
///     name : John
///     born : 02:11:2022 
///     address:
///             Address
///                 street : Oak
///                 number : 20
///                 city : PC Town
///                 
/// 
/// For example, a single person object can have a list of addresses representing all addresses this person
/// uses, like home work or correspondence address.
/// 
/// In this case, we have three classes composed together: Person, Address and List.
/// 
/// One person object has one list object which contains many objects of type address.
/// 
/// Objects are like building blocks from which we can compose very complex applications but still keep
/// the code easy to understand and modify.
/// 
/// 
/// Objects can also contain methods.
/// For example, we could have a rectangle object whose internal data are two integers representing the
/// lengths of the sides of the rectangle.
/// 
/// 
/// This object could also have methods calculating the rectangle's area and circumference.
/// Objects can represent much more abstract concepts too.
/// We could have a DatabaseConnector object whose job is to provide communication with a database or a
/// TextFileReader object reading files from the computer's memory and returning their content as strings.
/// 
/// To define what data and methods objects of some type will contain, we create classes.
/// A class is like a blueprint based on which we can create many objects, also called instances.
/// 
/// For example, we can have a Person class describing what data person instances will contain.
/// But all those instances can represent different people.
/// It is the same as with blueprints of some machines or buildings.
/// The blueprint is created once and, based on it,
/// many machines or buildings can be created.
/// 
/// We have already used some classes defined in the C# standard library.
/// For example, lists, arrays and strings.
/// When those built-in types are not enough, we define our custom types by creating our own classes.
/// We can also use structs and records which we learn about later in the course.
/// The difference between classes, structs and records are rather technical.
/// 
/// This OOPs helps with less error in code.
/// 
/// Object-oriented programming heavily relies on four fundamental concepts: encapsulation, polymorphism,
/// abstraction, and inheritance.
/// 
///