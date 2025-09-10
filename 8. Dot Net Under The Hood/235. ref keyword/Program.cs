// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// We said that when a value type variable is passed as an argument to a method, its copy is created.
// Whatever change is applied to this parameter in this method will not affect the original variable.
// What if, for some reason, we wanted the change of the value type parameter to be reflected as reference type.
// Well, we can do it by using the ref modifier.


int number = 5;
// ref:
AddAnotherOne(ref number); // To pass a variable by reference, we must also use the ref keyword here.

// out:
// For below method:
// We pass the varibale name that is not initialized yet.
// This method will set it to ten, so Console.WriteLine will print 10.
// We could declare this variable before like this.  
// int otherNumber; or
// Initialized it like : int otherNumber = 10; 
// If you do this then method call will change to : MethodWithOutParameter(out otherNumber); 
// Now, even the otherNumber is declared or initialized and it is int that is a value type,
// still below method will not create the copy of this varibale in the parameter and will change the value 
// of original variable i.e. the once which is passed to the method.
// This is the same behaviour as the ref keyword.
// But the diff is, when you use the out keyword,
// the variable which it has been used, needs/ must be reassigned in the method.
// So if in below method we did not update the otherNumber then we will get the error.
MethodWithOutParameter(out int otherNumber); 

Console.WriteLine(number);
Console.WriteLine(otherNumber);
Console.ReadKey();

void AddAnotherOne(ref int number) 
{ 
    number++;
}
// It now works as if the integer was a reference type.

// There is an important rule related to using the ref parameters.
// The variable we pass as a ref parameter must be initialized earlier. I.e. int number = 5;

// Earlier in the course, we learned about the out parameters, which can help us bypass the limitation
// of returning only one result from a method.
// Let's see an example of a method using an out parameter.

void MethodWithOutParameter(out int number)
{
    number = 10;
}


// Using the ref keyword is often considered a red flag in the code.
// It simply causes confusion and forces us to track what exactly happens to a value type variables in all the methods they are passed to.
// If you are tempted to use the ref keyword, make sure there is no other way to achieve what you want.
// If you recall, we said before that using out parameters also isn't the best design.
// If you want to return multiple results from a method, consider bundling them in a tuple or
// define a custom type representing this complex result.
// What is interesting, we may also use the ref modifiers with the reference type parameters.
