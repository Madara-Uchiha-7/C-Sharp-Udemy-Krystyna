///
/// We will discuss methods signatures and how to design them well.
/// First of all, let's understand what method signature is.
/// 
/// It is the method's name, parameters, return type, and all modifiers(static, seal..etc).
/// In other words, everything except the method body.
/// 
/// We know the names should be based on verbs, precise and clear.
/// 
/// If a method returns a boolean, its name should be a question that can be answered with yes or no.
/// But a method the name does not exist in isolation.
/// When reading it, we will read it together with the arguments.
/// That's why, when thinking of a good method name, we should keep the whole signature in mind.
/// 
/// One more e.g.
/// _fileWriter.Save("someString");
/// What does it do?
/// Save "someString" text to a file.
/// Save text to a file named "someString".
/// 
/// So, its name should be _fileWriter.AppendText for 1st case and "_fileWriter.WriteTo" in second case.
/// 
/// So as you can see in all those cases, we read the method's name and its argument in a single natural
/// sentence.
/// 
/// A good method signature speaks for itself, even without the methods name.
/// 
/// 
///