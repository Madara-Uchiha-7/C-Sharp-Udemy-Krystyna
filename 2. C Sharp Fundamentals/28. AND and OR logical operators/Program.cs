///
/// We will also learn what short-circuiting optimization is and, in relation to this topic, in what order
/// we should put logical expressions.
/// Finally, we will talk about the proper naming of Boolean variables.
/// 
/// 
/// && 
/// This is the and operator.
/// 
/// || 
/// This is the or operator.
/// 
/// Condition1 && condition2 && so on...
/// && will make sure if all the conditions are true and if one fails then
/// all false will be returned. If any one condition is false then others will not be checked.
/// This optimization is called short-circuiting.
/// 
/// While as || will check if any one is true if any one is true then true will be returned.
/// The || will not check remaining conditions if any 1 condition is true.
/// For e.g. if condition1 is true then condition2 will not be checked.
/// This optimization is called short-circuiting. 
/// 
/// When we have plenty of conditions in a single expression, it's best to use parentheses for clarity.
/// As remembering the precedence of operators is not so easy.
/// 
/// We should put the more lightweight operations on the left hand side and the heavier ones on the right
/// hand side.
/// So under some circumstances, the ones to the right will not even be evaluated.
/// 
/// Always name your boolean variables as :
/// e.g.
/// isLargerThanGivenInput 
/// Always do it in a form of a question which can be answered with the words true or false.
/// This is a good practice when naming Booleans, which makes it very easy to read the code using them,
/// and especially the if and else conditional statements which will learn about in the next lecture.
/// 
/// 
/// 
/// 
/// 
/// 
///