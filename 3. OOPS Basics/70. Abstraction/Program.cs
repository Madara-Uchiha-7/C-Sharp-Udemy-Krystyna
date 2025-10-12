///
/// We will also understand the benefits of hiding the implementation details from the users of a class.
/// 
/// DateTimes can be an excellent example to show one of the fundamentals of object-oriented programming.
/// That is Abstraction.
/// 
/// Abstraction means that classes expose only essential data and methods and hide the underlying details.
/// 
/// So what details does the DateTime hide?
/// Well, the great thing is that we don't even need to know.
/// We are perfectly fine using DateTime without understanding how it works under the hood.
/// 
/// 
/// It's similar to using a car.
/// We only need to know how to interact with things like the steering wheel, pedals and dashboard
/// and we can drive.
/// 
/// 
/// Lets see whats under the hood of date time.
/// Each date is represented as a number.
/// For example, January the 1st of 2022 is represented internally as 
/// private readonly ulong _dateData;
/// number called _dateData.
/// 
/// It is the number of ticks that have passed since January 1st of year one.
/// Each tick is 100 nanoseconds.
/// The DateTime struct can translate this number to more human-readable components of date and time.
/// How it does it does not really matter for us.
/// We only care that the result is correct.
/// 
/// As you can see, the date time type is quite complex, and it handles all things like daylight saving
/// time, leap year etc.
/// For us, as users of this type, it is very convenient that all those low-level details are hidden from
/// us and we don't need to bother ourselves with them.
/// 
/// We only operate on the public interface (e.g. .Day or AddYears() etc )of this class.
/// The public interface simply means all data and methods that can be accessed from a type.
/// We can't use the internal data.
/// For example, accessing the dateData field would not compile.
/// 
/// We should design our classes in the same abstract way, only give the users the interface to operate
/// on the type and hide all the implementation details.
/// The public interface is not something that frequently changes in opposite to implementation details.
/// Same as Car,
/// We can replace the engine, battery, and many other things, but will still drive the car in the same
/// way.
/// The factory in which cars are produced will not need to update the user manuals because how the car
/// is operated will not change. 
/// 
/// 
