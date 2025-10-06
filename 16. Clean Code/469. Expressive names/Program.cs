///
/// Let us now discuss how to name things so that our intentions are expressed clearly and precisely.
/// A good name should always express the intentions of the programmer.
/// 
/// If a variable or a method requires a comment to be added, it means its name is bad.
/// 
/// If a variable or a method requires a comment to be added, it means its name is bad.
/// 
/// e.g.
/// instead of Clear()
/// you can use
/// RemoveTrailingWhitespaces()
/// or
/// TrimTrailingWhitespaces()
/// 
/// 
/// One more e.g.
/// We can name the variable result if you want to return it from method.
/// Because mostly programmers return the result from the method so they name their method result.
/// 
/// One more example, if a class is called FileWriter, it should write to files.
/// It would be very fishy if it had other public methods, like a method checking if a file exists.
/// Of course it may have private methods for doing anything it needs like checking if file exists.
/// 
/// After all, it is reasonable to check if a file exists before we write into it.
/// 
/// But the operation of checking the file existence should not be part of this class's public interface.
/// 
/// 
/// 
///