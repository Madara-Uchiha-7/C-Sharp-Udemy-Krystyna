///
/// We will learn how to define void methods, so methods that do not return any value.
/// We will understand the difference between defining the method and calling it, as well as between the
/// methods parameter and argument.
/// 
/// Methods are used so that we do not repeat the code.
/// 
/// E.g you want to add the 2 numbers and you will be doing that a lot of times in the code.,
/// Then create the method with that logic and call that method each time you need to add the 
/// 2 numbers so that you do not have to write the logic each time.
/// 
/// Syntax: Method Definition:
/// return_type method_name (type parameter1, type parameter2, ...) { // code inside the method }
/// 
/// How to call the method:
/// method_name(argument1, argument2, ....);
/// 
/// return_type means what type method returns.
/// void means method does not return anything.
/// 
/// You can grab the value which method returns in the variable while calling that method:
/// type_name_which_method_will_return variable_name = method_name(argument1, argument2, ....);
/// You can use var instead of type_name_which_method_will_return 
/// 
/// Parameter means we can pass the variables or values to that method
/// which method will access inside its code logic.
/// 
/// The Parameters are not compulsary.
/// 
/// The arguments should match the parameter number.
/// The arguments are nothing but the values which will be taken by parameter.
/// 
/// 
/// 
/// Please notice that unlike for variables, the method name should start with a capital letter.
/// 
/// Parameters are named with the same convention as variables.
/// So starting with a lowercase letter.
/// 
/// 
/// If method return something then you need to add the 
/// return keyword in that method 
/// return_type method_name (type parameter1, type parameter2, ...) 
/// {
///     return value;
/// }
///
/// 
/// Sometimes while debugging we actually want to enter the method that is being executed.
/// To do so, instead of pressing F10, we must press F11 or click or the Step Into button.
/// 
/// In debubg mode 
/// if you  click on the yellow arrow
/// (which shows which line to be executed next) and drag it up,
/// It allows us to go back with the code execution to some line to execute it again.
/// 
/// 
/// 
/// Instead of defining the method by hand, we can right-click on calling method name and select a handy menu called
/// Quick Actions and Refactorings.
/// We could also click on the method and press Alt+Enter.
/// From here select generate method yourMethodName.
/// 
/// Unlike variables, we can use methods before they are declared.
/// 
/// 
/// --------
/// 33. Methods Part 3
/// We will learn the difference between statically and dynamically typed programming
/// languages.
/// Additionally, we will learn the difference between runtime errors and compilation errors.
/// 
/// C# is a statically typed programming language.
/// It means that during the compilation, the compiler checks if there are no type mismatches in our code.
/// 
/// And for example, if we don't do anything like assigning an int to a string variable.
/// The good thing is that the compiler checks if we use types correctly, so we won't experience runtime
/// errors related to type mismatch.
/// 
/// Runtime errors happen when the application is running in opposite to the compilation errors which happen
/// during the compilation.
/// 
/// The downside is that we must always use correct types, which makes the language a bit more rigid than
/// dynamically typed languages.
/// 
/// This is the price for better resistance to errors.
/// 
/// We can use methodds as a parameter types.
/// 
/// 
/// The return keyword always ends the method execution.
/// We can do
/// return; in the void type method which will stop its execution.   
/// 
/// 
/// 
/// Usually, we want the more essential and high-level methods at the top of the file and the low-level helper
/// methods at the bottom of the file.
/// 
///