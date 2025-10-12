// There is no need to create the object on this class.
// Because we want to use it by anyone.
// So creating the object of the class to call the methods is pointless.
// So we will use the static keyword.
// This Calculator class is called as the stateless class i.e. it has no fields
// or property which can get modified at the runtime.
// Others classes with fields are called stateful classes.
// Static methods belongs to a class as whole not to the perticular instance.
// Static methods can not use the instance data (using of fields or returned by properties)
// To call static methods we need to use ClassName.MethodName()
// This is how we use the Console class all the time.


Console.WriteLine(Calculator.Add(1, 2));
public static class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;

    // Const are implicitly static varibales
    // You have to use class name to use them too
    public const int sides = 4;

}
// If we make the class static that is : static class ClassName
// then we can not instantiate the static class.
// It only works as the container of the method. 
// Static classes can only contain static methods.
// Thought non static class can contain static method and to call them you use class name.
// If you hover over the method then press control + click on that class name
// then VS will directly go to the definition of the method.
// We can not call non static method from static method
// becuase non static method may have some fields which will be depentent on
// perticular instance.
// It is a good practice to make private method static if does not use any fields.
// This above way will show that this method does not change or use any state of object.
// Static methods work slightly faster.
// VS gives suggestion also that method can be static. 
// The const varibale value can not be changes. So, it is not needed to store it 
// for each instance individually. So static const saves memory. So all const fields
// are implictly static.
// So, to access these const fields, we need to access them like as we do for const methods.
// i.e. Using class name