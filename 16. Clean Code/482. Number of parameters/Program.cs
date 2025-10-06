///
/// We will talk about methods parameters and how their number can affect the cleanliness
/// of the code.
/// 
/// The rule of thumb is simple:
/// The fewer parameters the method has, the better.
/// The perfect number of parameters is zero.
/// Parameterless methods are very easy to use as we don't need to think at all about what they need to
/// work.
/// 
/// The more parameters we have, the more mistakes we can make.
/// 
/// So as we see, methods with no parameters or only one are easy to grasp at first glance.
/// On the other hand, if a method has 4, 5 or 10 parameters, it will be really hard to understand
/// it and calling it will be troublesome as we will need to think carefully about each of those numerous
/// parameters to ensure they are all valid. 
/// 
/// There is one more argument for having few method parameters: the simplicity of unit tests.
/// When we write unit tests of a method, we should make sure we test the method for each relevant combination
/// of arguments.
/// It is easy to do when there are only a few parameters, but the more parameters we have, the more complex
/// the unit tests will become and the harder it will be to test all relevant combinations.
/// 
/// So having only few parameters sounds great in theory, but how do we achieve it in practice?
/// Lets check in next lecture.
/// 
///