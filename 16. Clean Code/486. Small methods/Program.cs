///
/// We'll talk about how big the methods should be.
/// You will probably not be surprised by hearing that methods should be small.
/// The smaller, the better.
/// 
/// One-line methods are pure joy to read. With only one glance
/// we know what the method does.
/// 
/// On the other hand, if a method is huge, understanding it becomes nearly impossible.
/// The worst methods I have seen in my career were monsters longer than a thousand lines with tens of if
/// statements, for loops and return keywords.
/// 
/// If such a method returned an unexpected result or threw an exception
/// understanding what went wrong was torture.
/// 
/// If this method needed to be modified
/// it was a risky business as it was hard to predict the consequences of even a minor change.
/// Of course, it was not properly unit tested because testing such huge methods is extremely hard.
/// Obviously such a method did not do one thing only it had dozens of responsibilities that should be delegated
/// to other methods that would be smaller and more focused.
/// A reasonable guideline is that it should fit on a single screen.
/// Screens are various, but even small screens usually fit methods about 120 characters wide and around
/// 20 lines long.
/// 
/// If a method is smaller than that, the person reading it will not be forced to scroll vertically or
/// horizontally to see it all at once.
/// When it comes to the method's width it is quite easy to keep it small.
/// As in most modern languages, we can freely break long lines.
/// 
/// Let's now focus on the method's number of lines.
/// If it is more than 20, we should ask ourselves if this method does one thing only.
/// Usually such long methods do more.
/// We should refactor them by moving distinct pieces of functionality into our methods. 
/// 
/// -------------------------------------------------------------------------------------------------
/// There are a few Lectures After this, I'm going to write information about those lectures Below.
/// 
/// 1. Each method can do one job. It should not do more than that. 
/// 2. There are levels of Abstractions in method. 
/// For example, one method can call another four methods. 
/// In those four methods, 2 may be more important than other two. 
/// Then those two will be called or come in higher abstraction. And other two will come in lower abstraction. 
/// 
/// 
/// Example from quiz. 
/// a[0] + a[1] + a[2]
/// and
/// someCollection.Add(items);
/// 
/// In this above example second one that is sum collection will come under higher abstraction because
/// It works on any collection. While first one comes under the lower abstraction because it works on specific data type that is array. 
/// 
/// 
/// If it makes sense and code is already clean, it is OK to have few lower abstraction method calls with higher abstraction method calls. 
/// There will be always one controller method, for example Run() Which will be the controller method which will call all other methods. 
/// 
/// Still, it is always better to have a method which only includes higher abstraction method callas. 
/// Then those higher abstraction methods will only include the methods which call lower Abstraction method calls
/// and so on.
/// 
/// 
///