///
/// We will explore a few common examples of using comments in an extremely poor manner.
/// We will also discuss what the alternative solutions could be.
/// 
/// 
/// Let's start with the "captain obvious" comments.
/// By that I mean comments like "constructor of the person class" placed just above, you guessed it, the
/// constructor of the person class.
/// 
/// Other examples could be comments explaining the purpose of well-named variables or methods.
/// They give us absolutely nothing and they only clutter the code.
/// 
/// Not to mention that if, for example, a variable is renamed, the comment will remain unchanged and
/// become obsolete.
/// 
/// The alternative here is simply remove such comments and let the code speak for itself.
/// The next category of useless comments are the ones that are meant to help navigate the code.
/// 
/// For example, teacher saw many times for loops like this with a comment saying where the loop ends.
/// They were usually placed by the ends of loops that were too long or in a code that was poorly formatted.
/// Again, the solution is simple.
/// Format your code well, so the loops beginning and end are aligned (i.e. loops are not so big
/// that you need to scroll down).
/// If the loop is so long that it is hard to say where it ends, it means it should be refactored.
/// 
/// The next category of comments that indicate the need for refactoring are comments like this describing.
/// what happens in the given block of code.
/// Don't create such comments.
/// Move the code to a well-named method.
/// 
/// We are getting close to discussing the greatest hits of bad comments.
/// The silver medal goes to change log comments.
/// Some developers feel the need to document each change they make in a file.
/// 
/// This makes zero sense in modern coding, where we have powerful source control tools like Git.
/// In such tools, we describe each change with a short message.
/// The change log can be retrieved for any file without cluttering the code with comments.
/// 
/// Finally, the gold medal of bad comments goes to the commented-out code.
/// Imagine you open a file and read a class, but then you see that one method is commented out.
/// What does it mean?
/// Is this method needed or not?
/// Can we remove it or will we ruin someone's work?
/// Many developers are afraid to delete such commented-out code, so it remains in the code base forever,
/// becoming less and less connected to the code that is in use.
/// Don't comment out the code.
/// If a piece of code is not needed, remove it.
/// Use version control tools like, for example, Git so you can restore this code if, after some time you
/// realize it was needed after all.
/// 
/// Let's move on to the next lecture where we will discuss a few examples of using comments well.
/// 
/// 
///