///
/// Let's now discuss the scenarios when using comments may be a good idea.
/// But first, a basic rule.
/// If you really, really must add a comment, write the best comment possible.
/// Make it clear, precise and complete.
/// Don't ever add comments that are some messy cluster of words only you will understand.
/// 
/// Comments are, at best, the necessary evil.
/// We should always think really hard if we can express the same thing with the code.
/// 
/// Sharing our thoughts with code is always better than with a comment.
/// But sometimes explaining something with absolute clarity using the code is nearly impossible.
/// Let's say you implement some pretty complex algorithm in your method.
/// 
/// For example, the adaptive heap sort.
/// 
/// No matter how hard you try to name your variables well, a developer who isn't familiar with this
/// algorithm will not understand it.
/// In this scenario, leaving a short comment with the link to the algorithm description may be useful.
/// (Website link which explains the algorithm.)
/// The developer who needs to understand the code will simply go to a Wikipedia article and read about
/// the algorithm used.
/// 
/// Remember, this is still not an excuse to keep the code of such a method messy.
/// 
/// Another example of when the code may be hard to understand, no matter how clean it is, is when we
/// use regular expressions also known as Regexes.
/// 
/// Remember, regular expressions are patterns used for matching and manipulating strings, providing a
/// powerful tool for text, search and manipulation.
/// 
/// We don't want to force the readers of our code to decipher the regexes we use.
/// In this case, leave a comment that describes the regex and shows some examples of strings that will
/// match it and some that will not.
/// 
/// Sometimes our code gets a bit hacky, but for certain reasons we cannot make it right at the moment.
/// For example, teacher remembers a situation when a team used a library that overall worked great, except that
/// it threw an exception when they tried to instantiate some object for the first time.
/// 
/// For some mysterious reasons it only worked the second time.
/// 
/// It seemed like a quite a complex bug and there was no time to figure it out before some important deadline.
/// 
/// So they left this weird code that initialized the object two times with a short comment about why they
/// did it.
/// 
/// Another category of comments that can be considered reasonable is to-do comments describing what needs
/// to be done in some code.
/// 
/// Teacher is not against such comments, but with a couple of conditions.
/// Generally, the remaining tasks should be documented in dedicated tools like Jira.
/// We should not treat the cold as a place to manage the work. To-Do
/// commands should rather be used for some minor improvements, like refactoring a specific method or adding
/// error handling.
/// 
/// Additionally, they should be consistent in format so they can be easily found.
/// e.g.
/// // todo : comment
/// 
/// Each to-do
/// comment should mention the date when it was left and the person who is responsible for it.
/// Additionally, we should implement some way of tracking them all.
/// For example, we could use some static code analysis tools which can find all todos and list them,
/// ideally treating each as a warning.
/// 
/// This way, the developers will constantly be reminded of the remaining to-dos and will not forget to
/// deal with them.
/// Overall, we should treat such to-dos as short-lived entities.
/// If your to-do comment hangs in the code for weeks, you do something wrong.
/// 
/// 
/// The next commonly used comments are the summary commands.
/// Each language has its own way of defining them.
/// This is how they look in C#:
/// <summary>
/// Calculates the sum of elements
/// in the specified collection.
/// </summary>
/// <param name="numbers">Numbers to sum.</param>
/// <returns>The sum of elements.</returns>
/// <exception cref="ArgumentNullException">
/// Throw if numbers is null
/// </exception>
/// <exception cref="OverflowException">
/// Throw if sum of elements in 'numbers'
/// is larger than the max value of an 'int'.
/// </exception>
/// 
/// They work as a method's documentation.
/// For example, they determine what will be shown in Visual Studio when we hover over a method.
/// They may get outdated with code changes.
/// So it is important to keep an eye on them when we update the code.
/// Because of this extra work related to their maintenance.
/// We usually don't want to add them to all methods, only to those we mean to share in libraries.
/// 
/// The last category of reasonable comments are the ones describing the copyrights.
/// Some companies have a policy of adding such comments to each file.
/// Ideally, they should be short, perhaps only carrying a link.
/// 
///

