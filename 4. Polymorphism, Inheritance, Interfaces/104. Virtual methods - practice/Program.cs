// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

List<int> numbers = new List<int> { 1, 4, 6, -1, 12, 44, -8, -19};

//int sum = new NumbersSumCalculator().Calculate(numbers);

bool ShallAddPositiveOnly = true;

NumbersSumCalculator calculator = 
    ShallAddPositiveOnly ?
    new PositiveNumbersSumCalculator() :
    new NumbersSumCalculator();

Console.WriteLine(calculator.Calculate(numbers));
///
/// Since ShallAddPositiveOnly is true. The NumbersSumCalculator (base class) variable will point to the
/// PositiveNumbersSumCalculator (child class) object. Now, calculator is pointing to the
/// PositiveNumbersSumCalculator. Since it is a child class and Calculate() is public parent class method,
/// the calculator will call this method of base class even thoght it points to the child class object.
/// Because child class can access the parent class public and protected.
/// Now in Calculate() method there is a method called ShallBeAdded(). Now,
/// since the object we hold is of child plus this method is virtual in parent and overriden in child,
/// the method from child will be called.
/// NOTE : We can not have the virtual fields.


Console.ReadKey();

public class NumbersSumCalculator
{
    public int Calculate(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            if (ShallBeAdded(number))
            {
                sum += number;
            }
        }
        return sum;
    }
    // Access modifiers comes first.
    // Other modifiers go in between.
    // Return type will come last.
    protected virtual bool ShallBeAdded(int number) => true;
}

public class PositiveNumbersSumCalculator : NumbersSumCalculator
{
    protected override bool ShallBeAdded(int number)
    {
        return number > 0;
    }
}