///
/// We will understand the relation between the number of digits in a number and the maximal
/// value of this number.
/// 
/// The important thing to realize is that by using a limited number of digits, we can represent limited
/// numbers.
/// 
/// Let's start with the decimal number system.
/// The highest digit in this system is 9.
/// So, for example, the largest number we can represent with three digits using the decimal system is
/// 999.
/// 
/// Now let's consider the binary number system.
/// The highest digit in this system is one.
/// So, for example, what is the largest binary number we can define using four digits?
/// 1111
/// i.e. 15 in decimal.
/// 
/// Let's go back to the decimal system.
/// How many different numbers can we represent using three digits.
/// Well, we will need to find the number of all possible combinations of those three digits.
/// For the first digit, we have ten options because we can choose digits between 0 and 9.
/// For the second digit, we also have ten options and the same for the third.
/// So we have ten times, ten times ten possible combinations, which gives 10^3 = 1000 combinations.
/// 
/// Each of those combinations represent a different number.
/// In a collection of 1000 unique numbers starting at zero, the largest is 999.
/// In other words, we can calculate the largest number that can be stored using a given number of digits
/// by calculating 10 to the power of the number of digits minus one.
/// 
/// Max Number = 10^Number Of Digits - 1.
/// 
/// Let's do the same calculation for a four digit binary number.
/// How many combinations can we have here?
/// We have two possibilities of how to set the first digit to how to set the second two to set the third
/// and two to set the fourth.
/// This gives 2 by 2 by 2 by 2 combinations, which is 2 to the power of 4.
/// So using four digits, we can find 16 unique combinations, each giving a different number. In a collection
/// of 16 unique numbers starting at zero
/// the largest is 15.
/// 
/// We calculated the largest number that can be stored using a given number of digits by calculating two
/// to the power of the number of digits minus one.
/// 
/// Max Number = 2^Number Of Digits - 1.
/// 
/// So it is the same calculation we had for the decimal system.
/// The only difference is that we use a different system base.
/// Let's use this knowledge to find the largest binary number we can store using eight digits.
/// It is 2 to the power of 8 minus one, which gives 255.
/// 
/// 
/// 
///