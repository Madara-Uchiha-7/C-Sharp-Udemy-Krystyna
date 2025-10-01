///
/// We will learn what numeric overflow is and why it may be dangerous.
/// We will also understand silent failures.
/// In the previous lecture we added two numbers, 13 and 15.
/// Both were stored on four bits, but the result, which was 28, needed five bits to be represented.
/// 
/// If we did this calculation using some four-bit numeric type, the result could not be represented using
/// the same type.
/// 
/// We cannot fit a five-bit number on four bits of memory.
/// Well, the last most significant bit would just be discarded.
/// And the actual result our computer could see would not be 11100, which is 28, but 1100, which is
/// 12 - something completely different and simply wrong from the arithmetic point of view.
/// 
/// 
/// 
/// A situation when a number cannot be represented on the bits of a given
/// numeric type is called a numeric overflow.
/// 
/// We now understand why the result of adding two integers of value 2 billion gives an invalid result.
/// 2 000 000 000 + 2 000 000 000 = -294 967 296
/// 
/// If you are curious why it is negative, remember that the most significant bit in an integer represents
/// a sign.
/// 
/// In this case, after discarding the exceeding bits, it must have happened that the leftmost bit that
/// was left was equal to one, and because of that the whole number was interpreted as negative.
/// 
/// An integer is not able to represent the number 4 billion as it would require more than 32 bits.
/// The thing that can worry us is that no exception is thrown.
/// We are not informed in any way that something went wrong.
/// 
/// Such a situation is called a silent failure and it is nothing good.
/// 
/// 
/// 
///