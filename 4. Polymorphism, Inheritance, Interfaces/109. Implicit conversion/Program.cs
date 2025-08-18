// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// Explicit cast expresstion : (Season) on line 5.

internal class Program
{
    private static void Main(string[] args)
    {
        int seasonNumber = 0;

        Season spring = (Season)seasonNumber; // enum defined below

        // There are two types of conversion 
        // Implicit and Explicit
        // Implicit:
        ///
        /// Does not require cast expression.
        /// Is done when conversion is safe and lossless.
        ///

        // Decimal type
        // Decimal is used to represent precisely floating-point numbers.
        decimal a = 10.01m; // I was getting error, so used quick fix using right click and main method is created.
        // We added m in the end. If not then it will become 10.01 which is a double value and 
        // C# compiler will complain. double is less precise than the decimal but faster than it.
        // This m stands for money.

        int a1 = 10;
        decimal a2 = a1;
        // As you can see, even though a1 is int, it did not show any error when assigning 
        // it to the demical. how? C# is statically typed language and we can't assign 
        // the value of one type to variable of another type.
        // Ans: The implicit conversion happens behind the scenes.
        // This above a1 integer is converted to the decimal.
        // Conversion from int to decimal is always safe and lossless.
        // Decimal number can represent any integer.
        
        Console.ReadKey();
    }
}

public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}