///
/// Let's now understand the benefits of composition over inheritance.
/// We will go one by one through the issues inheritance caused and consider whether and how using composition
/// would solve them.
/// ----------------
/// The first issue was a tight coupling between base and derived classes.
/// Even a minor change in the base class could force us to change the derived classes, which meant our
/// code was brittle.
/// 
/// Using composition, it is no longer the case.
/// The PersonalDataFormatter and the PersonalDataReader classes know nothing about each other.
/// They are independent and can be modified without affecting one another.
/// 
/// They only communicate via the interface, but interfaces change much less frequently than the implementation
/// details.
/// --------------
/// Inheritance also made our code less reusable.
/// When the people reading functionality was defined in the abstract method and methods overriding it,
/// we could not reuse it elsewhere without using the classes that contain them.
/// So the PersonalDataFormatter classes.
/// Now we can easily compose the data reader classes with any other types not related at all to formatting
/// people's data as strings.
/// -------------------
/// Before, the relationship between the data formatter and its inheritors was rigid and defined at compile
/// time.
/// This is also no longer the case.
/// If a new type implementing the people data reading interface is added, its instance can simply be given
/// to the constructor of the PersonalDataFormatter class.
/// 
/// -------------
/// We are also rid of the limitation of classes having only one base type.
/// The classes implementing the IPersonalDataReader interface can implement as many other interfaces as they want.
/// It is another change that makes our code more flexible.
/// We also don't need to worry that the derived classes will inherit too much from the base class and learn
/// too much about their implementation details.
/// The inheritance is no longer used, and the only point of contact between those classes is the interface.
/// 
/// -------------
/// With inheritance there was a risk that the class hierarchy would grow significantly,
/// if, for example, we added the ability to format the data in a short or a long way.
/// This is no longer a problem.
/// If we need various ways of formatting, we can simply add one more category of types(interface) into the composed
/// design.
/// 
/// The PersonalDataFormatter would simply depend on one more interface type implemented by two concrete
/// classes. One formatting the data in a short way and one in a long way.
/// 
/// No matter how many various traits we will implement here, the structure of types will still be pretty
/// flat.
/// 
/// We will have multiple interfaces implemented by some types and that's it.
/// The hierarchy will not go deeper than one level.
/// --------------
/// Unit testing will be very simple now.
/// When testing the PersonalDataFormatter, we will simply mock the PersonalDataReader.
/// Also the classes for reading the data can be tested in isolation.
/// If a change happens in any of those classes, it will only affect one test fixture.
/// 
/// -----------
/// The last inheritance issue we discussed was not related to this code but to data structures.
/// If they inherit from one another, it causes issues,
/// If we wanted to store this data in databases using object relational mapping tools.
/// 
/// With composition
/// one object simply stores another inside.
/// And this is something databases can easily understand.
/// -----------
/// 
/// If you are ever tempted to use inheritance, ask yourself if you couldn't use composition instead.
/// It will most likely be a better design choice.
/// 
/// 
/// 
/// 
///