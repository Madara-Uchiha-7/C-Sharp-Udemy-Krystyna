using System.Diagnostics;

///
/// We will learn how to represent fractions in C#
/// precisely.
/// 
/// With that, we will learn more about decimal and we will also compare it with double.
/// 
/// In the previous lectures we saw that doubles and floats are not perfectly precise.
/// This is fine for many applications, but not all.
/// For example, imagine a banking system that cross-checks some transactions.
/// It must be sure that after the money transfer, the amount that was taken from one account is exactly
/// the same as the amount that was added to another account.
/// 
/// If we use double for representing money, this could lead to errors.
/// Both amounts would be represented as some approximations and they could not be exactly equal.
/// 
/// That's why, for representing money, we should always use decimals.
/// 
/// Decimal is optimized for precision.
/// It has 128 bits.
/// It Has a smaller range and operations on it are slower, but it is precise.
/// +-1 * 10^-324 to +-7.9*10^28
/// It has precision of around 28-29 digits.
/// 
/// Of course, like any C# numeric type, because of its size limitation, we can't represent numbers
/// smaller or larger than this.
/// So precision numbers = possible number of digits.
/// 
/// But within this range, the operations will give correct results without any surprises.
/// It is called a decimal because it is a decimal floating point number.
/// So the base that is raised to the power of the exponent is ten.
/// 
/// First, let's see the code that we had before, but this time let's use decimals.
Console.WriteLine(0.3m == (0.2m + 0.1m));

///
/// We gained precision, but at what price?
/// Let's measure it.
/// Let's see how DoubleTest()And DecimalTest() will do when the number of iterations is 30 million.
/// 
int iterations = 30_000_000;

Console.WriteLine(DoubleTest(iterations));
Console.WriteLine(DecimalTest(iterations));
// o/p:
// 131
// 1666

Console.ReadKey();

long DoubleTest(int iterations)
{
    Stopwatch stopwatch = Stopwatch.StartNew();
    double z = 0;

    for (int i = 0; i < iterations; i++)
    {
        double x = i;
        double y = x * i;
        z += y;
    }
    stopwatch.Stop();
    return stopwatch.ElapsedMilliseconds;
}
long DecimalTest(int iterations)
{
    Stopwatch stopwatch = Stopwatch.StartNew();
    decimal z = 0;

    for (int i = 0; i < iterations; i++)
    {
        decimal x = i;
        decimal y = x * i;
        z += y;
    }
    stopwatch.Stop();
    return stopwatch.ElapsedMilliseconds;
}
///
/// Doubles are not only faster, but they also have a much larger range while occupying less memory.
/// As you can see, the range of the double is just ridiculous, which makes them perfect for some scientific
/// uses, when one often operates on very small or very large numbers. Also, double takes only eight bytes while
/// decimal takes 16. 16 bytes is 128 bits - 4 times as much as an integer takes.
/// 
/// In general, we should use doubles or floats when representing some numbers coming from nature like
/// physical measurements, which by definition are not perfectly precise. Doubles are great for representing
/// things like length, speed, position on the map and such.
/// Because of their great performance, they are widely used in some industrial applications,
/// video games etc.
/// 
/// Decimals are much slower.
/// They occupy more memory and have a smaller range.
/// But they guarantee precision.
/// We should use them when we can't allow any approximations.
/// when representing money, points in a game or other human-made concepts that we need to represent
/// precisely.
/// 
///