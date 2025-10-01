///
/// We will learn what floating point numbers are.
/// 
/// We already know how integral numbers can be represented in a computer's memory.
/// But what about fractions?
/// e.g. 
/// 324.56
/// 
/// Well, we can actually represent them using integral numbers.
/// Let's understand floating point numbers.
/// To represent a floating point number, we will need two integers: mantissa and exponent.
/// Mantissa gives some scaled representation of the number while the exponent says what the scale is.
/// In other words, the exponent says where the point will be placed.
/// That's why they are called floating point numbers, because the point is not fixed in place, but it
/// moves, allowing us to represent both very large and very small numbers.
/// 
/// This all probably sounds a bit mysterious.
/// So let's see an example.
/// 
/// We will represent the number 324.56 with mantissa and exponent.
/// The pattern is simple.
/// We multiply the mantissa by the base of the system raised to the power of the exponent. 10 to the
/// power of -2 is 0.01.
/// 
/// So, 32456 * 0.01
/// So the result is 324.56 as expected.
/// 
/// As you can see, we managed to represent a floating point number with integers only.
/// This representation used the decimal system whose base is ten.
/// But as we know, computers prefer the binary system.
/// Binary floating point numbers work the same, but the base is two.
/// 
/// Let's understand how floating point numbers are represented in a computer's memory in the following
/// lecture.
/// 
/// 
///