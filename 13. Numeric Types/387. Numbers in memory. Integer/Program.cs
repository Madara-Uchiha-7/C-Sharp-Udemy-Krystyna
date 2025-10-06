///
/// We will understand how numbers are stored in a computer's memory.
/// We will also take a closer look at the integer type.
/// 
/// Each piece of information in the computer's memory is a series of bits, zeros and ones. To represent
/// a number in memory
/// we must simply store its binary representation on a series of bits.
/// For example, to store number 13, we must find 4 empty bits and set them to 1101.
/// 
/// Almost every numeric type in C# occupies a fixed number of bits.
/// Because of that, each of them can store numbers of limited size.
/// For example, an integer occupies 32 bits
/// no matter if its value is 1, 1 million or 1 billion.
/// Integer occupies 32 bits, which is the reason why int is an alias for int32.
/// We can use those names interchangeably as they both mean the same type.
/// The 32 bit integral numeric type.
/// So what is the largest number that can be represented on 32 bits?
/// Well, it is 2 to the power of 32 minus one, which is this number = over 4 billion.
/// I.e.
/// 4 294 967 295
/// 
/// But as it turns out, the maximal value of the integer is not this, but this.
/// It is:
/// 2 147 483 647
/// 
/// The reason for that is simple. Integers can also represent negative numbers.
/// The leftmost of the 32 bits will be used to represent the sign.
/// If this bit is set to one, it means the number is negative.
/// This will leave 31 bits for the number itself, so the maximal value of the integer will be two to the
/// power of 31 minus one, which is:
/// 2 147 483 647
/// A little more than 2 billion.
/// 
/// On the other hand, the smallest value is this.
/// -2 147 483 648
/// 
/// We don't need to remember them exactly as we can always refer to int.MinValue and int.MaxValue constants.
/// It is enough to remember that they are around -2 billion and plus 2 billion.
/// 
/// Since each numeric type has a limited range, an interesting question occurs: What happens if we add
/// 2 billion to 2 billion using integers?
/// 
/// Well, long story short, the result of such an operation will be incorrect.
/// To be specific, it will be this number.
/// -294 967 296
/// 
/// But to understand why, we must understand the addition of binary numbers, which we will do in the
/// next lecture.
/// 
/// 
/// 
///