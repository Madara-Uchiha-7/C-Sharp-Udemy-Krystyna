///
/// We will learn about the principle of the least surprise.
/// This principle says that the code we write should behave in a way that most programmers will expect
/// it to behave.
/// 
/// In other words, the readers of the code should never be surprised by what they see.
/// 
/// I.e. method name suggests something else but code is for something else is not a good thing.
/// 
/// 
/// Following the principle of least surprise boils down to this:
/// The methods and classes should do what their names say they should do only this thing.
/// They should do it well and they should not do anything else.
/// 
/// 
/// E.g. if method name is SaveUser
/// but if its saving the user on some condition
/// then that if condition should not be written in this method.
/// This valid logic should be in diff method and if condition will call that method.
/// 
/// ----------------------------------------------------------------
/// This is from next lecture: Not related to Principle of the least surprise.
/// One more e.g.
/// We can not name the Interface method as 
/// ReadFromSQLDatabase
/// This way this interface will lose its purpose.
/// Because interface can also be used by any other class, but what if that class want to read but not
/// from SQL database. So, avoid giving such names.
/// Also
/// What happens here is something we call leaking implementation.
/// It means the name describes the implementation details of a method.
/// It shouldn't happen.
/// The users of this method do not care whether it uses an SQL database or not.
/// They just want to know that it reads some objects.
/// The solution here would be renaming this method to something more generic.
/// e.g. simple Read().
/// The concrete classes
/// implementing this nterface could be named more specifically.
/// For example,PeopleFromSqlDatabaseReader or PeopleFromExcelFileReader
/// Of course, those names also expose the implementation details, but the difference is that the classes
/// depending on them, would not be aware of that.
/// Because we will be using the interface name in the constructor
/// which will point to the objcets of these classes.
/// 
/// 
/// One more e.g. from next lecture:
/// Dont name parameters are array1 and array2
/// Name it:
/// source and target.
/// 
/// 
///