///
/// We will use a technique called column addition.
/// If you are not familiar with it, link to an article explaining it:
/// https://www.mathsisfun.com/numbers/addition-column.html
/// 
/// When using this technique, we add the numbers in the columns from right to left and carry over the
/// rest if the sum cannot be represented with a single digit.
/// This technique also works for binary numbers.
/// 
/// Let's add binary 13 to binary 15.
/// 
/// 13 can be represented as 1101 
/// and
/// 15 as 1111.
/// First, we add the numbers from the rightmost column.
/// One plus one is two, but we can't use two in the binary number system.
/// The maximal digit allowed is one.
/// This means we need to carry it over to the next column.
/// We will write zero in the first column of the result because the modulo of the sum we calculated, which
/// was two and the base of the system, which also is two, is zero.
/// Now, the second column. Again, the sum is two.
/// So we carry over to the next column.
/// Time for the third column.
/// Now the sum is 3.
/// We carry over one to the next column and we write one in the result.
/// We do it because the modulo of the sum we calculated, which was 3, and the base of the system, which
/// is two, is one.
/// Finally, the fourth column. The Sum is 3 again
/// so we carry over one and we leave one in the result.
/// It turns out that we actually need the fifth column to fit the one that we carried over from the fourth
/// column.
/// This time it is simple.
/// The sum of numbers in the fifth column is one, so we just write it down.
/// 
/// 
/// --------------------------------------------------
///  Carry:    1    1       1       1
/// --------------------------------------------------            
///                 1       1       0       1
/// +               1       1       1       1
/// --------------------------------------------------
///            1    1       1       0       0       
///            
/// 
/// 
/// It is 16 plus 8 plus four 4 0 plus 0, which is 28.
/// But notice a very important thing.
/// We needed to use one more digit to represent this number.
/// Now, let's go back to thinking about computers.
/// If we had a numeric type that only had four bits, it would simply not be able to hold the result we
/// calculated.
/// 
/// 
///