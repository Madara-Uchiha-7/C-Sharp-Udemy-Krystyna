///
/// We will also learn one of the purposes of the "default" keyword.
/// Additionally, we will understand what expressions are.
/// 
/// We used the group of if/else statements earlier.
/// So when we have multiple if else conditions scenario, we can alternatively use the switch statement.
/// 
/// The switch statement provides a way to transfer the execution to different paths of code based on the
/// value of an expression.
/// 
string input = "A";

switch (input)
{
    case "A":
        Console.WriteLine("The input is A.");
        break;
    case "B":
        Console.WriteLine("The input is B.");
        break;
    case "C":
        Console.WriteLine("The input is C.");
        break;
    default:
        Console.WriteLine("Input is not A and B and C.");
        break;
}

/// Here is how we define a switch statement. In those parentheses
/// we provide an expression. i.e. input variable we given. 
/// An expression is any code that evaluates to a value.
/// So, for example, it can be a variable or a function call.
/// 
/// Then we write as many case labels as we want to. Each with a specific value.
/// If this value equals the result of this expression, the code belonging to this case will be executed.
/// 
/// So if the userChoice variable equals "B", that case code will be run.
/// 
/// Please notice that we can have multiple lines of code for each case.
/// i.e. we can add more than : Console.WriteLine("The input is A.");
/// 
/// But each case must always end with the "break" keyword or with the "return" keyword
/// if the switch statement is contained within a method.
/// 
/// The switch statement will give the same result as this code using the if/else statements.
/// 
/// The switch statement is shorter and more readable most of the time.
/// 
/// With switch we can use a special case called default.
/// The default case is executed if the expression given in the parentheses does not match any of the cases.
/// 
/// 
/// We can make Swith behave as a OR condition.
/// E.g. the A or B or C can be small also that is a or b or c.
/// Then:
switch (input)
{
    case "a":
    case "A":
        Console.WriteLine("The input is A.");
        break;
    case "b":
    case "B":
        Console.WriteLine("The input is B.");
        break;
    case "c":
    case "C":
        Console.WriteLine("The input is C.");
        break;
    default:
        Console.WriteLine("Input is not A and B and C.");
        break;
}

/// 
/// Now we have two cases, one right below the other.
/// This code will be executed when input variable is either lowercase or uppercase.
/// We can have as many cases leading into the same code block as we want.
/// 
/// 
/// 
///