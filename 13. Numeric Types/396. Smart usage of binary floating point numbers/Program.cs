///
/// We will learn how to manage
/// the fact that floats and doubles are not perfectly precise.
/// 
/// We will also learn what our reasonable use cases for them.
/// Additionally, we will see what NaN is.
/// 
/// Since floats and doubles are approximations of numbers and are not very precise, we should avoid checking
/// if they are equal to one another.
/// 
/// When checking their equality, we should rather check if the difference between them is so small that
/// we don't actually care about it.
/// 
/// So the simplest implementation of a method checking doubles equality could be this.
/// Check method AreEqual()
/// In this method, we simply check if the absolute value of the difference is smaller than the tolerance.

Console.WriteLine(AreEqual(0.3d, 0.2d + 0.1d, 0.000001d));
bool AreEqual(double a, double b, double tolerance) =>
    Math.Abs(a - b) < tolerance;
/// 
///
/// One more note about doubles.
/// A variable of double type can have a specific value called NaN - Not a Number. 
/// 
/// It is reserved for representing undefined mathematical operations, like, for example, dividing zero
/// by zero.
Console.WriteLine(0d / 0d);
// We will get NaN for above.
///
/// 
/// Let's see one more thing.
var result = 10d / 0d;
///
// In Debug mode, if you check the result, it will be infinity.
/// This result is another special value, the infinity. This is for doubles  only.
/// Since 0d is only an approximation of zero, we should rather think of it as a special, very, very,
/// very small number.
/// 
/// 10 divided by these very, very small number is just a huge number.
/// So huge we consider it infinity.
/// 
/// So what the use cases for doubles and floats are:
/// Well, there are many scenarios when we don't expect perfect precision of some things.
/// Generally all things coming from nature or some physical measurements.
/// For example, imagine a program tracking the flight parameters of a plane.
/// Things like velocity or altitude are never precisely measured.
/// But we don't care if a plane is at 11,200m or 11,200m and one-tenth of a centimeter.
/// Doubles and floats are also used in all types of programs using physics simulations, including video
/// games.
/// 
/// For example, to determine if a character in a game hits the wall.
/// We only check if it is very, very close.
/// We don't need to check if the distance between the character and the wall is actually equal to zero.
/// 
/// We've learned that doubles and floats are not perfectly precise, and we must be careful when making
/// assumptions about them.
/// 
/// For example, the equality of two double numbers may not be the same as it would be in real world mathematics.
/// For some scenarios, we need precision and we can't make any compromises about that.
/// 
/// In those cases, we can use decimals, which we will learn about in the following lecture.
/// 
///