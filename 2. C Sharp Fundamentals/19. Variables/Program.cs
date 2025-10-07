///
/// We will understand what variables are.
/// We will also learn about two important C# types: int, and string.
/// 
/// Then we will see what the variable's declaration and initialization are and what the difference
/// between them is.
/// 
/// Additionally, we will learn a useful shortcut that duplicates a line of code.
/// 
/// 
/// Visual Studio
/// gives us a simpler way of duplicating lines of code.
/// 
/// With the cursor on the line we want to duplicate, we can press Ctrl+D.
/// In VS Code it is : 
/// Alt + shift + down arrow 
///
/// We can think of a variables as boxes used to store some values.
/// A variable must have a name, for example, "userInput" and the value it currently stores
/// for example "A". Also each variable must be of some type.
/// For instance, if I declare some variable as a string so simply text I can't store a number in it.
/// In C#, once a variable has been declared, its type cannot be changed; only its value can be
/// modified.
/// Even if my box stores string "A" at first, I can change it to "ABC", but I cannot change it to 1.
/// 
/// If it is a string, then its value must be in double quotes.
/// string stringValue = "test";
/// Here stringValue is the variable and test is its value and string is the type of the value.
/// 
/// We can use this variable and, for example, print it by simply passing it to the Console.WriteLine method.
/// While modifying the variable do:
/// stringValue = "new value";
/// 
/// I.e. no need to add the type again.
/// 
/// Similarly, if you want to save the integer then:
/// int number = 10;
/// 
/// For now, we learned about two types: strings representing textual data and ints representing whole numbers.
/// 
/// There are many more types ready to be used with C#, and we can also create our own types.
/// 
/// 
/// Below 
/// We are declaring and initializing the variable at the same time:
/// string stringValue = "test";
/// The declaration means specifying that a variable with given type and name will exist.
/// Initialization means assigning an initial value to it.
/// Please note that we can do it in two steps.
/// 
/// int number1;
/// number1 = 12;
/// 
/// I can declare a variable without initializing it and then initialize it later.
/// 
/// 
/// If we declare a variable of some type, but we try to initialize it with another type, it will not
/// work.
/// We can use the varibale before they are declared.
/// 
/// If we want, we can declare multiple variables of the same type in a single line.
/// 
/// typeName variable_name = value, variable_name = value;
/// 
///