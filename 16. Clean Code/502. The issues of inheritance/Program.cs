///
/// We will understand what issues inheritance causes.
/// It will help us see why using composition instead is a better idea.
/// 
/// Any change in the Abstract base class will affect the child base classes.
/// For example, if we add a new constructor to the base class, we will also need to add the same constructors
/// to the derived classes.
/// 
/// Derived class method will be dependent on the base class method, which will make it 
/// tightly coupled with the base class.
/// So, we can not use that method as we want.
/// 
/// Inheritance has even more disadvantages.
/// For example, remember that in C# and many other programming languages, we can only inherit from
/// a single base class.
/// There are good reasons for this limitation, but it is a limitation nonetheless.
/// Also, it is often the case that the derived type inherits more than it actually needs.
/// The base class exposes the implementation details to inheritors, which is never good.
/// Another problem with using inheritance is that it can make the hierarchy of classes grow rapidly.
/// 
/// The next issue of inheritance is related to unit testing.
/// Lets say we have 1 base abstract class and 2 base classes.
/// Now, we have one abstract class and two non-abstract inheritors.
/// 
/// Remember that abstract classes cannot be instantiated.
/// So we cannot create an object of the base class for unit testing purposes.
/// 
/// So how can we test each of those classes?
/// Well, there are two approaches for testing abstract classes and their inheritors, both with their
/// own problems.
/// We can have two test fixtures, each testing one inheritor(derived classes).
/// In both test fixtures, we will also test the common part belonging to the base class.
/// This means our tests will be partially duplicated.
/// If anything changes in the base class, we will have two test fixtures to adjust.
/// Alternatively, we can test inheritors, ignoring the logic belonging to the base type as much as possible.
/// Then, we can test the base abstract class logic by creating a dedicated concrete type derived from it
/// only for testing purposes.
/// In the tests of this class, we would focus on testing the base class logic.
/// But this is even worse than the first way.
/// The tests of the base type would not be realistic as they would actually test a type that is not used
/// in the app.
/// It only exists for testing purposes.
/// 
/// There would be still a big chance that if something changes in the base class, we will need to adjust
/// three test fixtures.
/// 
/// There is one more reason for avoiding inheritance that is not related to the classes we have:
/// It occurs when we inherit one data structure from another.
/// Inheritance is tricky when working with object-relational mapping tools like, for example, Entity
/// Framework. Object-relational mapping frameworks allow the mapping of objects to records in relational
/// databases.
/// They let us easily read database records as objects and then save objects into databases.
/// 
/// 
/// They handle creating SQL queries under the hood, and they can also create database tables automatically
/// in such a way that they will reflect the types we defined in the code.
/// 
/// The problem is that the databases don't really understand inheritance.
/// So mapping the C# hierarchy of inheritance into a flat structure of tables is tricky and often
/// leads to overcomplicating the tables in the database.
/// 
/// 
/// 
/// 
///