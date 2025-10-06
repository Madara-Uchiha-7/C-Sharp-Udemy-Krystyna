///
/// We will discuss how to reduce the number of method parameters by splitting the method.
/// Suppose we have a method that takes many parameters.
/// In that case, we should ask ourselves an important question.
/// Does this method do one thing only?
/// If not, we should split it.
/// 
/// 
/// Let's consider this method.
/// It takes game data object and saves it to a file.
/// Overall, it takes three parameters.
/// This number is not terrible, but two would be better.
/// The problem with this method is that it does two things instead of one.
/// It builds the complete file name by merging the value of this parameter with the extension.
/// Then it saves the game data object to the file whose name was just built.
/// But they are two unrelated responsibilities.
/// 
/// This method is called SaveGame, so it should focus on saving the game.
/// Knowing how to build a file name is not its job.
/// 
/// We should refactor this code by creating a separate method called, for example, BuildFileName.
/// It will take two parameters: the file name and the file extension, and it would return a complete file
/// name.
/// 
/// The save game method should operate on such a complete file name and don't bother itself with building
/// it. This way both those methods would only have two parameters and each would have only one responsibility.
/// 
/// This would have one more benefit.
/// We could use the BuildFileName method wherever we needed to combine the file name with the file extension
/// With the old design
/// this functionality was locked inside the SaveGame method and it couldn't be used anywhere else.
/// 
/// Let's discuss other ways of achieving this in the following lecture.
/// 
///