///
/// It works almost the same as the decimal system.
/// The only difference is the base.
/// It will not be ten, but two.
/// 
/// E.g
/// 1101
/// Let's start the same as before by marking each digit with its index starting from the right.
/// 
///   Number         Index
///     1              3
///     1              2
///     0              1
///     1              0
/// 
/// In the decimal number system, we calculated the powers of ten and then multiplied them by the corresponding
/// digit.
/// Here it is the same.
/// But we calculate the powers of two.
/// 
/// (1 * 1^3) + (1 * 1^2) + (0 * 1^1) + (1 * 1^0) 
/// 
/// It's 8 plus 4 plus 0 plus 1, which gives 13.
/// This means 1101 in the binary system is 13.
/// 
///