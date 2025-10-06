///
/// Let's now discuss the importance of the context in which a name functions.
/// 
/// Take below e.g.:
/// 
/// var state;
/// 
/// It is hard to say what it means without any context.
/// Is it a state of some process or maybe one of the United States?
/// It is impossible to say by the variable name only.
/// 
/// To figure it out, we would need to read the surrounding code.
/// It would be better if the variable name would show its purpose right away.
/// addressState
/// Now it is clear that this is a part of the address and will store values like Texas or Ohio.
/// 
/// Renaming the variable is one way of clarifying what kind of state it is.
/// Alternatively, we can enclose this variable in a type that will describe its context.
/// So instead of having a bunch of variables called addressNumber, addressCountry and addressState,
/// we would just bundle them in a struct called Address.
/// struct Address { string Number; string state; string Country; }
/// 
/// Then we could remove the address prefixes from those variables names.
/// Generally, we want to avoid repeating a piece of information in two or more places.
/// If a State field belongs to Address struct, it is obvious it means a state like California or Florida
/// and not a state of a process.
/// 
/// Similarly, we should avoid repetition between the names of methods and classes in which they are contained.
/// For example, if we have a class called Text File Writer, there is no need to name its method
/// WriteToTextFile.
/// This information is already included in the class name, so it is clear from the context,
/// we can safely shorten the name of this method to Write.
/// 
/// 
/// 
/// 
///