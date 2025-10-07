///
/// We will discuss where particular variables can be used and where they cannot.
/// 
/// 
/// Scope defines a part of our program where some particular variable is accessible.
/// The variables we've been learning about so far are called local variables.
/// There are other kinds of variables in C#, but we'll learn about them later in the course.
/// 
/// Let's understand what the scope of local variables is.
/// If you create any variable in the if block then that variable,
/// you can access only till the end of the if block i.e. till } of the if block.
/// 
/// This means If you create any variable that is present in the {}
/// then that variable will be accessible only inside that {}.
/// This is called as the local variable because you can not access it outside of the {}.
/// 
/// 
/// The variable which you define outside of {}
/// e.g. 
/// string name = "test";
/// if ( condition ) {} else {}
/// The name variable will be accessible in the if and else both.
/// 
/// 
///