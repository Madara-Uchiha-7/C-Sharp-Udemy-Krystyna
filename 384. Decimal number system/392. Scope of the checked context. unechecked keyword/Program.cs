///
/// We will see how to enable checking for numeric overflow globally for a project.
/// We will also learn the purpose of the unchecked keyword.
/// Finally, we will understand what the scope of a checked context is.
/// 
/// It may happen that we will prefer to have all operations in a project checked for numeric overflow.
/// This may affect the performance, but if we are sure about that, we can do it.
/// 
/// Let's see this option.
/// Open this project properties.
/// And scroll down to advanced section.
/// You will see
/// "Check for Arithmatic Overflow"
/// 
/// If we checked this checkbox, all code in this project would be checked for numeric overflow.
/// 
/// In this case, if we wanted some code not to be checked for overflow, we could use the unchecked keyword.
/// It defines a scope in which the arithmetic operations will not be checked.
unchecked
{ 
    // Your code inside here will be skipped from checked. 
}
///
/// Before we move on, we must mention one tricky thing about the checked keyword.
/// The overflow check only applies to the immediate code block, not to any function calls inside the block.
/// I.e. if you have a method call written in the checkck {}
/// I.e. you are calling another method from checked{}
/// Then the code inside that method will not be checked.
/// You will need to add the checked {} inside that method also.
/// 