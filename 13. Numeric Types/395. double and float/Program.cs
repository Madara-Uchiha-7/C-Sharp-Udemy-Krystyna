///
/// We will take a close look at the binary floating point numbers in C#.
/// So double and float.
/// In C#, we have three types for representing floating point numbers.
/// Float, double and decimal.
/// 
/// 
/// So for now, let's focus on float and double.
/// they are the same, but they differ in size.
/// Float occupies 32 bits and double 64.
/// One of those bits is reserved for the sign and the rest is used for the mantissa and exponent.
/// In the case of double and float the base of the system,
/// so the number that we raise to the power of the exponent, is 2.
/// That's why we call them binary floating point numbers.
/// 
/// Earlier we used the base of ten, so it was a decimal floating point number.
/// Floating point numbers come with a serious problem.
/// 
/// If the mantissa has limited precision and it does in computers, or even if we try to write it down
/// on a piece of paper, it means we can't represent some numbers in a perfectly precise way.
///  
/// Type        Range                                               Precision
/// float       +-1.5 * 10^-45 To  +-3.4 * 10^38                 ~ 6 to 9 digits.
/// double      +-5 * 10^-324  To  +-1.7 * 10^308                ~ 15 to 17 digits.
/// 
/// For example, if you wanted to write the number one-third on a piece of paper, you would fill it with
/// 0.3333333 and so on.
/// 
/// But finally you would run out of paper.
/// Whatever number you would write, it would be some approximation of the number that is actually one
/// third.
/// 
/// The same as with the paper
/// you can run out of bits when representing such a number in programs, which leads to a representation
/// that is not precise.
/// 
/// Let's use double as an example.
/// 
/// Double is a binary floating point number occupying 64 bits.
/// We said that the numbers, like one-third are impossible to be represented in the decimal number system
/// with a finite number of digits. In the binary system
/// an example of such an unrepresentable number is one-tenth.
/// Let's use it as an example proving the lack of precision of double.
///
Console.WriteLine(0.3d == (0.2d + 0.1d));
// From the point of view of real-world mathematics, this should evaluate to true.
// But you will get false here.

// Let's learn how to deal with this issue in the following lecture.