///
/// We will understand why making public methods static may be a bad idea.
/// e.g.
/// Here we have a class called DataAccess with a public GetData method.
/// Let's imagine it opens a connection to an SQL database and gets the data from there.
/// As you can see, this method does not use any instance data, so technically it could be made static.
/// The DataProcessor class is given the DataAccess object as the constructor parameter:
///     private readonly DataAccess _dataAccess;
///     public DataProcessor(DataAccess dataAccess)
///     
/// It stores it in a field which is used in the method where reading data is needed.
/// As you already know, this design goes against the dependency inversion principle.
/// The DataProcessor class should depend on an abstraction, not on a concrete type.
/// The reason for that is that now we are not able to easily switch the implementation of this method to
/// something else.
/// If one day we would like to use another class that can read this data perhaps from some file or an API,
/// we could not do it without modifying the code of the DataProcessor class.
/// At the very least its constructor.
/// Also imagine we want to test this class.
/// We don't want to use the actual database connection in unit tests.
/// We want to use a mock.
/// But currently there is no easy way to switch this implementation to a mock one.
/// It would be better if this class depended on an abstraction, not on a concrete type.
/// In C#, such abstractions are usually represented by interfaces.
/// Let's change the design to make sure this code is compliant with the dependency inversion principle.
/// We have added IDataAccess. 
/// DataAccess will now implement the IDataAccess.
/// Also we changed the DataProcessor 
/// property from class to interface and constructor will take the object of DataAccess through 
/// general type:
///     private readonly IDataAccess _dataAccess;
///     public DataProcessor(IDataAccess dataAccess)
/// 
/// The DataProcessor is only given an object of this interface which hides the implementation details.
/// DataProcessor is not aware of what object it is exactly.
/// It may be that DataAccess class using the SQL database, but it can be something completely different,
/// like an object reading data from a file or even a mock used for testing purposes.
/// This change in design makes this code much more flexible because now we can easily switch the implementation
/// passed here to something else without modifying the DataProcessor class.
/// This class is no longer tightly coupled with the DataAccess.
/// Now those two classes live in separation and they only communicate via the IDataAccess interface.
/// Additionally, we will be able to test the DataProcessor class easily.
/// As for testing purposes, we will not use the actual database connection, but it's mock.
/// 
/// But let's go back to thinking about static methods.
/// We said earlier that the GetData method does not use the instance state, so it could be made static.
/// Let's say we decide to do it.
/// From : public List<int> GetData()  To : public static List<int> GetData()
/// 
/// now this method is static, We must call it differently in the DataProcessor.
/// i.e. using the class name instead of instance name.
/// 
/// Field : private readonly IDataAccess _dataAccess;
/// is no longer in use, so will comment it.
/// 
/// 
public class DataAccess : IDataAccess
{
    // public List<int> GetData() 
    public static List<int> GetData()
    {
        return new List<int>() { 1, 2, 3 }; 
    }
}

public class DataProcessor
{
    // private readonly DataAccess _dataAccess;  : Original
    // private readonly IDataAccess _dataAccess; : Updated to this bcz we are using interface.

    // public DataProcessor(DataAccess dataAccess) : Original
    // public DataProcessor(IDataAccess dataAccess) // : Updated to this bcz we are using interface.
    //{
    //    _dataAccess = dataAccess;
    //}
    // We commented updated constructor and filed because we are calling GetData() on class name not
    // on its object.

    public int CalculateSum()
    {
        // return _dataAccess.GetData().Sum();
        return DataAccess.GetData().Sum();
    }
}
public interface IDataAccess
{
    List<int> GetData();
}

/// But we just lost all the benefits that following the dependency inversion principle gave us.
/// We can't now easily switch this implementation to something else nor replace it with a mock implementation
/// for testing purposes.
/// We no longer pass this object as a constructor parameter.
/// We are bound to this specific implementation.
/// Notice that additionally, this code no longer compiles.
/// The DataAccess class can no longer implement the IDataAccess interface.
/// The methods implementing interfaces are implicitly virtual, and virtual methods cannot be static.
/// Remember, the runtime uses the type of an object to determine which implementation of a virtual method
/// it should invoke.
/// But static methods are not invoked on objects.
/// They are invoked on a class as a whole.
/// 
/// That's why a method can either be virtual or static.
/// Never both.
/// And this is the reason why we should avoid making public methods static.
/// If a method is static, it will always behave the same and we will not be able to change the code's
/// behavior by calling this method on another object.
/// This makes the code more rigid and very hard to test as we are not able to mock static methods.
/// 
/// Long story short, it is rarely a good idea to make a public method static.
/// If there is the slightest chance the methods implementation will need to be switched to another one
/// It will not be possible when this method is static.
/// 
/// In the following lecture, we will discuss the rare scenarios when a public method should be made static.
///
///