///
/// We will learn the purpose of the var keyword.
/// 
/// Also, we will understand what implicitly and explicitly typed variables are.
/// 
/// Until now, we have always been declaring the types of variables explicitly like this.
/// string name = "John";
/// 
/// If we think about it, declaring the types here is redundant.
/// We see clearly that this is a string and so does C# compiler.
/// 
/// Because of that, we can use the "var" keyword instead of the type name.
/// 
/// So the only difference is that we did not have to declare the types explicitly, but the compiler inferred
/// them from the values we initialized those variables with.
/// 
/// Of course, this wouldn't work if we did not initialize the variables right away.
/// so,
/// var name;
/// is not allowed
/// but 
/// var name = "chinmay"; is allowed.
/// 
/// PTeacher usually use the "var" keyword, and I only declare types explicitly when it is not very clear
/// to the reader of the code what they are.
/// 
/// For example, if they are a result of some calculation.
/// 
///