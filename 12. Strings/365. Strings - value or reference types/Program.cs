// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// Strings are reference types.
// This might be counterintuitive.
// For example, typical reference types support reference-based equality.
// 
string text1 = "abc";
string text2 = "abc";
Console.WriteLine(text1.Equals(text2));
// text1.Equals(text2) will return true. 
// For typical reference types, the Equals method used like this should return false.
// We have two different objects here, so they should have different references and because of that they
// should be considered not equal.
// So in C# strings implement value based equality.
// Since the equals method is overridden to base on the value, GetHashCode is overridden as well.
// Two strings with the same values will have the same hash codes.
// As we know, when a variable of a reference type is passed as a parameter to a method, the reference
// is copied.
// So the object we operate on inside the method is the same object the variable passed as the argument
// has referenced.
// In other words, if the argument gets modified, it will also affect the object we passed to the method
// in the first place.
// But strings are immutable.
// They cannot be modified.
// So this is not really an issue.
// So, in method the string type does not modify the original string 
// rather assings the new value to it after calculating the operations on the right side of the =.
// New string will have a different reference than the string pointed to by this variable.
// My theory:
// It means, if string variable A is passed to the method as the argument.
// That method has a parameter string B. So, string B will now point to string A. Because it is a reference
// type. Now, if you modify the B by performing some operation like B = B + "Test"; 
// then new string will be created and B will point to the new Address instead of A.

// So if strings behave more like value types, then why aren't they? 
// Well, it's related to the large size of strings.
// Strings can be huge objects, and if they were value types, they could be stored on the stack.
// And remember, the stack is a small area in memory, occupying either 1 or 4MB.
// Storing strings on the stack could quickly lead to memory issues because the stack would simply not
// have enough free memory.
// 

Console.ReadKey();