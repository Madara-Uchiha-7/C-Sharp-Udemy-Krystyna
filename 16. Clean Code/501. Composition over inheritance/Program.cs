///
/// We will understand the differences and similarities between composition and inheritance.
/// We will also learn about a principle called composition over inheritance.
/// 
/// It is a design principle that states, as its name suggests, that we should favor composition over
/// inheritance.
/// 
/// Let's first understand the relationship between those two mechanisms.
/// Inheritance is a mechanism that allows a class to inherit properties and behaviors from another class
/// while giving it the ability to override some of them.
/// Inheritance can help us implement functionalities that have some common parts while differing in other
/// parts.
/// 
/// With inheritance
/// we can achieve this by creating two types derived from the same base type.
/// Each of those derived types can redefine the part that should be different between them.
/// This way, the common behavior is only defined once in the base class.
/// 
/// On the other hand, composition is a mechanism where a class is given objects that define the functionalities
/// this class needs.
/// It can serve a similar purpose as inheritance.
/// When we need two functionalities that are partially the same, but with distinct differences,
/// we can implement them by having one main class that manages the common part.
/// The part that differs will be implemented by an object given to this main class.
/// To achieve a different behavior, we can switch this object to another implementing the same interface.
/// 
/// In summary, we can achieve a similar result by using either inheritance or composition.
/// Yet, according to the composition over inheritance principle,
/// choosing composition is better.
/// 
/// The reason for that is simple: Inheritance causes a lot of design issues.
/// 
/// 
/// 
///