///
/// We will see that exceptions that a method may throw are, in a way, a hidden part
/// of this method's signature.
/// 
/// We'll also understand why it is a problem.
/// 
/// The great thing about methods with well-designed signatures is that we don't really need to look into
/// their implementations to have a pretty good idea of what they do.
/// 
/// CalculateEmployeeAge method obviously takes an employee object and calculates this employee's age.
/// 
Employee employee1 = new Employee();
employee1.YearOfBirth = 10;
int age = CalculateEmployeeAge(employee1);

/// But what if lets say this method does not necessarily calculate the employee's age.
/// It may do it, but it may as well throw an exception.
/// But the signature of this method does not say anything about it.
/// 
/// Signature of the method is this line:-> int CalculateEmployeeAge(Employee employee)
int CalculateEmployeeAge(Employee employee)
{
    if (employee.YearOfBirth < 1900 || employee.YearOfBirth > DateTime.Now.Year)
    {
        throw new YearOfBirthOutOfValidRangeException($"Person's year must be in between 1900 and current year.");
    }
    return DateTime.Now.Year - employee.YearOfBirth;
}

/// In other words, throwing an exception by this method is its side effect.
/// We rely on signatures of methods, treating them as a kind of contract.
/// We assume they don't lie to us and we design our code around it.
/// If we needed to look into every method's implementation to ensure we use it correctly, it would make
/// our coding much more challenging.
/// In this case, a simple solution would be to validate the year of birth of the employee during the creation
/// of the employee object.
/// But let's imagine that both the employee type and this method are not implemented by us, but are a
/// part of some library we use. And in that library they are throwing ArgumentOutOfRangeException.
/// So one more alternative is we can put :
/// int age = CalculateEmployeeAge(employee1);
/// into try and in catch we catch ArgumentOutOfRangeException.
/// Lets say that library was working fine and in new update they added YearOfBirthOutOfValidRangeException
/// in the place of ArgumentOutOfRangeException.
/// So, we again need to check the code in this method and raplace the catch for YearOfBirthOutOfValidRangeException.
/// 
/// If an exception was an explicit part of the signature of a method the same way as it is with the return
/// type or the types of parameters, at least we would be warned that something has changed because we
/// will start seeing compilation errors. 
/// Because changing the Exceptions inside the method will not cause the compilation errors but will cause the 
/// runtime error. So we need something which will give us the warning or error at the compile time.
/// 
/// The fact that exceptions add a side effect to a method which is not clearly shown in the method signature
/// is one of the reasons why exceptions are a controversial topic in the programming community.
/// 
///

class Employee
{
    public int YearOfBirth { get; set; } // Made public for line : employee1.YearOfBirth = 10;
}

class YearOfBirthOutOfValidRangeException : Exception
{
    public YearOfBirthOutOfValidRangeException() { }

    public YearOfBirthOutOfValidRangeException(string message) : base(message) { }

    public YearOfBirthOutOfValidRangeException(string message, Exception innerException) : base(message, innerException) { }
}