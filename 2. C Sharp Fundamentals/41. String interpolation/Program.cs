///
/// We will learn what string interpolation is and how to use it.
/// We can add the variables in the string or expressions in the string 
/// using $ and {} symbols.
/// 
/// This allows us to skip the + operator for string concatination.
/// 
/// E.g.
int a = 1;
int b = 2;
int c = 3;

Console.WriteLine($"The numbers are {a}, {b} and {c} and thier addition is {a + b + c}");

///
/// If you already have a string built using the addition operator, you can easily transform it to an interpolated
/// string by right-clicking on it,
/// selecting the Quick Actions and Refactorings menu,
/// and choosing "Convert to interpolated string".
///