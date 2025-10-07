///
/// TryParse() method will help us to avoid the runtime error like int.Parse()
/// But before we learn about this method in the next lecture, we must learn about the out keyword.
/// Sometimes we need to return two results from a method instead of one.
/// Lets say we want a method to return the array with its size.
/// 
/// Lets see the e.g.
/// We added a new parameter with the out modifier.
/// If we use this modifier, we must assign some value to this parameter within this method.
/// O.w. we will get the compilation error.
/// "The out parameter countOfNonPositive must be assigned to before control leaves the current method."
/// The parameter declared with the out modifier kind of works like the second result
/// we wanted to return from this method but couldn't due to the limitations of the language.
/// 
/// Here we  declare a new variable test and we pass it as an argument to the GetOnlyPositive method in place
/// of the parameter with the out modifier.
/// Please notice the out keyword here : GetOnlyPositive(numbers, out test);
/// What is interesting this variable is not first initialized. This is fine. In the method
/// it is enforced by the compiler that the parameter is assigned a value.
/// So after this method is finished we will be able to use this variable safely at it is surely already
/// assigned.
/// Actually, we don't really need to declare this variable here.
/// Like : int test;
/// We can do it right inside the method call like this.
/// GetOnlyPositive(numbers, out int test);
/// But for now, let's stick to the first syntax we used.
/// 
///

var numbers = new[] { 1, 2, 3, 4, 5, -4, -1, -9, 10 };
int test;
var onlyPositive = GetOnlyPositive(numbers, out test);
Console.WriteLine(test);

List<int> GetOnlyPositive(int[] numbers, out int countOfNonPositive)
{
    countOfNonPositive = 0;
    var result = new List<int>();

    foreach (var number in numbers)
    {
        if (number > 0 )
        {
            result.Add(number);
        }
        else
        {
            countOfNonPositive++;
        }
    }
    return result;
}

///
/// Now let's understand precisely what is going on. In the signature of the GetOnlyPositive method
/// we added an extra parameter with the out modifier.
/// When calling this method, we passed an integer variable as this parameter also using the out keyword.
/// When this method is executed, it will assign 
/// like : countOfNonPositive = 0;
/// and modify the value of this parameter.
/// So after it's done, this parameter will be set to whatever this method has set it to.
/// 
/// After this method, this variable is already set and we can safely use it.
/// 
/// 
/// So using the out keyword allowed us to bypass the limitation of returning only one value from a method.
/// 
/// This method still returns a list of integers, but additionally it also sets a value of a variable passed
/// to it with the out modifier.
/// 
/// You may wonder, but why do we even need this keyword?
/// Can't we just pass the variable to this method and let it change its value?
/// Well, it doesn't work this way.
/// 
/// When we pass a variable as a parameter to a method, a copy of this variable is created, and if it's
/// modified, it doesn't affect the original variable.
/// The out keyword changes this behavior.
/// When the out keyword is used, no copy is created.
/// The variable itself is passed to the method, not its copy.
/// The out keyword is not commonly used.
/// Usually if we need to return multiple results from a method, we pack them in some custom data structure.
/// 
/// 
/// 
/// We can have a method with only out parameter.
///