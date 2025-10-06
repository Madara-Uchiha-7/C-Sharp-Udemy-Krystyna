///
/// We already know that every piece of information stored in the computer's memory is saved as a series
/// of bits, zeros and ones.
/// 
/// Numbers are no exception.
/// Each number is stored as a sequence of bits.
/// 
/// The numeral system that allows representing numbers using only two digits,
/// so zero and one, is the binary system.
/// 
/// Before we understand the binary number system
/// let's do so with the system we use on a daily basis.
/// The decimal number system.
/// The base of this system is ten.
/// Any number larger than one can be used as a base of a valid number system.
/// Ten was the most natural for us humans as we have ten fingers and we started our journey of understanding
/// mathematics by counting them.
/// 
/*
    Name                 Base                   Highest Digit
    
    Binary                2                         1
    
    Decimal               10                        9

    Hexadecimal           16                        F(Value = 15)
*/
///
/// Let's consider the following decimal number.
/// 831
/// You don't need much explaining here.
/// You can imagine what it means to have $831 or any other currency you use, or a folder with 831 pictures
/// or a book with 831 pages.
/// 
/// We are so used to this system that we don't even think about the numbers.
/// We simply see them and know immediately what they mean.
/// 
/// But let's break it down.
/// Each digit has its place.
/// 
/// The further to the left it is, the more significant it is.
/// It means it carries more weight of the number. Digit
/// eight means 800, three means 30, while one simply means one.
/// We could mark each digit with an index counting them from right to left.
/// 
/// i.e.
/// Number : 831
/// Number    Index
///     8       2
///     3       1
///     1       0
///     
/// Now, for each of the digits, we want to multiply it by ten to the power of its index.
/// (8 * 10^2) + (3 * 10^1) + (1 * 10^0)
/// 
/// The sum of those numbers is the final number we want to represent.
/// (8 * 10^2) + (3 * 10^1) + (1 * 10^0) = 800 + 30 + 1 = 831
/// 
/// We now understand exactly how the decimal number system works.
/// It will make it much easier to understand the binary number system.
/// 
///