///
/// We can't talk about truly random numbers here because the numbers that are generated
/// are determined by the initial value called the seed.
/// 
/// For the same seed, we'll always get the same sequence of values.
/// 
/// So it's not really a random but rather a pseudorandom numbers generator.
/// 
/// We can pass any numeric seed to the constructor of the random class.
/// 
/// e.g. we can Do:
/// new Random(12);
/// 
/// We'll see that the same numbers will be produced.
/// 
/// 
/// This is because, as we said, for the same seed, the same sequence of numbers will be generated.
/// 
/// If no seed is passed to the constructor, the value of the seed is set to the number of ticks since
/// the system was started, where one tick is 100 nanoseconds.
/// If we create two objects of the random class at almost the same moment in time, they may have the same
/// seed and as a result give us the same sequence of numbers.
/// This leads to some pretty common bugs when someone expects two random objects to generate different
/// numbers, but in fact they generate the same numbers because they were created in the same window of
/// 100 nanoseconds.
/// 
/// The best approach is to have a single Random object in the entire program.
/// Which I have done in last lecture.
/// 
///
/// Having the unnamed number in arguments is an anti-pattern called the magic number.
/// It generates even more problems than simply confusing the programmers. 
/// When it comes to magic numbers is that, despite their names, they
/// don't necessarily have to be numbers.
/// They can also be bools strings, special dates, or anything else.
/// 
/// 
/// In play method 
/// we are using Console class static method.
/// To match with this
/// we made ConsoleReader class static.
/// 
/// 
/// To represent a game's victory or loss, we can create an enumerated type, often called an enum.
/// An enum type is a type that defines a set of named constants.
/// Please notice that even if an enum declaration is a bit similar to a class declaration, it cannot contain
/// any fields, properties or methods. 
/// 
/// Under the hood, each value of an enum is represented as an integer.
/// By default, the first value is zero, the second is one, and so on.
/// We can override these 0, 1, 2 and so on.
/// 
/// 
/// 
/// We created a Game folder.
/// In that we created the file "GuessingGame.cs"
/// Then moved all the classes in GuessingGame.cs
/// 
/// Then we selected each class name one by one
/// Then we right clicked for each of them 
/// Then "quick actions and refactoring" -> Move to new file.
/// We did this for all the classes except GuessingGame becasue this class is already in except GuessingGame.cs
/// file.
/// 
///

using DiceRollGame.Game;

var random = new Random();
var dice = new Dice(random);
var guessingGame = new GuessingGame(dice);

GameResult gameResult = guessingGame.Play();
GuessingGame.PrintResult(gameResult);

