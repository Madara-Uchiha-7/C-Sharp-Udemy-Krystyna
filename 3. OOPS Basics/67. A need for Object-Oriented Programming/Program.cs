///
/// We will learn what procedural programming is and what problems it can cause.
/// Additionally, we will understand what an anti-pattern is and, specifically what spaghetti code anti-pattern
/// is about.
/// 
/// Finally, we will learn what high quality code must always be ready for.
/// 
/// 
/// It is a good practice to separate high-level business decisions from low-level technical details.
/// For example, a high-level business decision says that the user can see, add or delete items. Low-level
/// detail is that they can communicate with the program via the console.
/// 
/// The thing about low-level details is that they often change.
/// The feature of adding items is unlikely to be removed, but communication via console can be switched
/// to something else.
/// 
/// 
/// If we as developers are one day asked to modify this application to have some graphical user interface
/// we'll have no easy way of achieving this with only methods.
/// 
/// 
/// Sometimes we are not simply asked to change the behavior of the code.
/// Instead, we are asked to give the ability to have two or more different behaviors depending on some
/// configuration.
/// 
/// 
/// Imagine that the todo list app user could decide to store the todos directly on their device or in
/// the cloud, depending on some settings.
/// 
/// Currently, this would be complicated and would involve filling our code with multiple if statements.
/// 
/// This code would not be easy to maintain, meaning any future code changes would be painful to implement.
/// 
/// 
/// It is crucial that we create our code in such a way that it is easy to be modified in the future because
/// the requirements change very often.
/// 
/// The paradigm this code(code with only methods) is in line with is called procedural programming.
/// The program is composed of procedures called methods, in our case, each containing a series of steps.
/// Those procedures are called from some main flow of the program or from one another.
/// We already mentioned some of the problems this paradigm can cause.
/// 
/// In general, it leads to creating something we call spaghetti code: a messy, tangled code as hard to
/// follow as following a single thread in a bowl of spaghetti.
/// It is hard to move or remove a single thread from such a bowl without moving anything else.
/// 
/// 
/// Change is the only constant in programming.
/// There are very few projects where the complete requirements are known in detail before developers start
/// the work, and never change during the development process.
/// 
/// 
/// By the way, spaghetti code is an example of an antipattern, so something we should avoid if our code
/// is supposed to be of high quality.
/// 
/// 
/// As a solution, a new paradigm called object-oriented programming was invented in the 60s and became
/// popular in the 90s.
/// 
/// Today it is the most followed paradigm and most mainstream programming languages support it.
/// 
/// 
/// 
/// 
///