///
/// We will understand what Hungarian notation is and why it is better to avoid it.
/// Hungarian notation is a naming convention for variables where a prefix or type indicator is added to
/// the variable name to indicate its data type.
/// 
/// For example, a variable representing somebody's age might be named intAge or a string variable representing
/// a last name might be called strLastName.
/// 
/// This convention had its uses many years ago, but using it in modern programming is simply a bad idea.
/// Adding the types indicator to the variable name does not give us any value and it may cause quite a
/// lot of trouble.
/// Firstly, it makes the name longer.
/// Long names aren't necessarily bad, but only if additional words carry important useful information.
/// The variable type is not useful.
/// We have other ways of seeing the type then including it in the name.
/// In modern IDEs, it is usually enough to hover over a variable to see its type.
/// Secondly, using the type in the variable's name makes reading the code less natural.
/// Ideally, we would like to make reading the code similar to reading prose.
/// Lastly, using the type name may be problematic if we decide to change the variable's type.
/// Let's say we have a variable named numbersList in the code.
/// At some point refactoring is performed and its type is changed from a list to an array.
/// If one forgets to update its name as well, it will become confusing.
/// One may see a variable named numbersList and try to add a new item to it using .Add, but it will not work because
/// the variable type will actually be an array.
/// 
///