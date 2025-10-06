///
/// Let's now discuss one of the most common mistakes related to naming things.
/// The use of abbreviations.
/// 
/// Many programmers love shortening the names everywhere they can.
/// For example, they write addr instead of address.
/// It is a mistake and it makes the code worse.
/// Address is a word that is easy to read.
/// We instantly know what it means.
/// We have seen this word thousands of times in our lives, and our brains recognize it immediately.
/// On the other hand, addr is some strange cluster of letters.
/// Our brains need to make a serious effort to figure out that it most likely means address.
/// It is even worse if the abbreviated name actually has a completely different meaning.
/// For example, if one shortened address to add.
/// When we see the word add, we naturally think about adding something, not an address.
/// We are simply confused when we realize the author of the code actually meant address.
/// Abbreviations may lead to other mistakes.
/// For example, what do you think this variable represents?
/// var prod
/// Production? Product?
/// We wouldn't need to guess and we would not risk misunderstanding if the programmer who named this variable
/// wrote a couple more letters.
/// 
/// Teacher noticed that many programmers, even if they know that abbreviations are bad, still use them in lambda
/// expressions.
/// Sure, lambda expressions are usually short and because of that it is hard to get lost in them.
/// But this is still not a reason to name their parameters in an unclear, hard to read way.
/// 
/// Also finding a good name is easy because it is mostly not repeated in others places.
/// For e.g if variable name is a instead of address
/// the searching it using Ctl + f will be hard.
/// 
///
