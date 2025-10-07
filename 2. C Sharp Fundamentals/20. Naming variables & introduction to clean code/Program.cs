///
/// We will learn how to name variables.
/// We will also see what reserved keywords are and how to use them as variable names.
/// We will also start discussing a very important topic which is clean code.
/// 
/// Finally, we will learn a handy shortcut for renaming elements in the code.
/// 
/// 
/// Let's now talk about how we should name our variables.
/// We can name them whatever we want, with some exceptions.
/// Some keywords in C# are reserved.
/// For example, I can't name a variable "int" because "int" is a reserved keyword used to represent integral
/// type.
/// 
/// All reserved words in C#:
/// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/
/// 
/// Sometimes we want to use a reserved word as a variable name anyway.
/// For example, if we are working on an app with which user can buy cruise tickets, we may want to use
/// the word "class" as a variable name, meaning the class of the ticket.
/// 
/// But "class" is a reserved keyword in C#, so we can't do it.
/// 
/// We can bypass this limitation by adding @ sign before the variable name.
/// 
/// All right, here are the rules on how to name variables in C#.
/// As we said keywords can't be used as variable names.
/// Names can contain letters, digits and the underscore character.
/// But the first character cannot be a digit.
/// C#is case sensitive.
/// Thus the names lowercase "count" and uppercase "Count" refer to two different variables.
/// Using an underscore works no matter if it's a first character or not, but it is not recommended. In C#
/// the standard Microsoft-recommended convention is to use lower camel case when naming variables.
/// It means the first character is a lowercase letter, and then we start each word with a capital letter.
/// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions
/// 
/// 
/// The names should be meaningful and precise.
/// Avoid abbreviations. There is no need to make variables names short.
/// "birthDay" is much clearer than "bd" and "firstElement" is better than "fe".
/// Be precise.
/// Don't use name1, name2 and name3
/// when you want to represent first name, middle name and last name.
/// Take your time when naming variables.
/// 
/// 
/// If you want to rename one word from whole code then
/// select that word and press : ctrl + R R
/// and F2 in VS Code.
/// 
/// 
/// 
/// 