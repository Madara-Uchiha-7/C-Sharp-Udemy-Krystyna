// Events are the .NET implementation of the observer design pattern.
// They enable an object to notify other objects when something happens.
// The mechanism of events is based on using delegates.
// So first, let's recall what they are.
// Delegates are special types, just like classes or structs.
// A variable of a delegate type can only be assigned a method with a signature
// described in the delegate.
// For example, let's declare a delegate like this.
// public delegate void SomeMethod(int a, int b);
// Please notice that the public modifier means that delegate is public, similar to a public class or
// a struct, and not that the method needs to be public.
// We will create a variable of this delegate type.

//Below line works because the signature of this method matches the signature of the delegate.
SomeMethod methods = Test1;
// Below line will not work because the signature of this method
// does not matches the signature of the delegate.
// SomeMethod method_2 = Test2;

// Remember that a variable of a delegate type can store references to multiple methods at once.
// We can add them using the plus equals operator.
methods += Test3;

// If we want to remove a method from the delegate variable, we can use the minus equals operator.
methods -= Test3;

// Lets add it again
methods += Test3;

// The methods stored in this variable can be executed in a very similar way to how ordinary
// methods can be called.
// This line will execute all methods stored in this variable with the given parameters.
methods(10, 2);


Console.ReadKey();

void Test1(int number1,  int number2) { }
void Test2(int number1, int number2, int number3) { }

void Test3(int number1, int number2) { }

public delegate void SomeMethod(int a, int b);

