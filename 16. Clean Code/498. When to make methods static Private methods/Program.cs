///
/// We will discuss when making methods
/// static is a good idea.
/// 
/// We will start with private methods.
/// First, let's make sure we remember what static methods are.
/// 
/// When a method is static, it belongs to a class as a whole, not to any specific instance.
/// Because of that, it doesn't have access to the instance data like the values stored in the fields or
/// returned by properties.
/// 
/// We know that if a method does not use any state(properties, fields..etc) of the class, it can be made static.
/// 
/// But the question is, should it be made static?
/// The short answer is that if the method is private, it should.
/// Making it static clearly shows that it doesn't use instance data and the programmer reading it knows
/// upfront that they don't need to think about the object state to fully understand what this method does.
/// 
/// Everything a method needs to work must be defined in its body or given as parameters.
/// There is no need to understand what fields and properties a given class has.
/// 
/// Additionally, static methods have a slightly better performance.
/// 
/// If the method is public, we should be very careful when making it static.
/// Let's understand why in the following lecture.
/// 
/// 
///