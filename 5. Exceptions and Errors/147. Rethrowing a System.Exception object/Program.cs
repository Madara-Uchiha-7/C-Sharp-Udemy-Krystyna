// We will learn how to manage the exceptions if we do not know exactly 
// what exceptions can be thrown from some code.

public class PersonDataReader
{
    private readonly IPeopleRepository _peopleRepository;
    private readonly ILogger _logger;

    public PersonDataReader (IPeopleRepository peopleRepository, ILogger logger)
    {
        _peopleRepository = peopleRepository;
        _logger = logger;
    }

    // ReadPersonData calls the Read method on _peopleRepository object 
    // We only know that _peopleRepository is the object of the IPeopleRepository interface.
    // Lets say exception is thrown from Read() method and you want to save it to some logs
    // so the developers can investigate it later.
    public Person ReadPersonData(int personId)
    {
        try
        {
            return _peopleRepository.Read(personId);
        }
        // Since we have no idea what exception might cause here, we can use System.Exception
        catch (Exception ex)
        {
            _logger.Log(ex);
            // _logger : When constructor will be called of PersonDataReader class, this _logger
            // will have some diff class obj which implements Logger
            throw;
        }
    }
}
public interface IPeopleRepository
{
    Person Read(int id);
}
public interface ILogger
{
    void Log(Exception ex);
}
public class Person : IPeopleRepository
{
    public Person Read(int personId)
    {
        Person person = new Person();
        return person;
    }
}

// Remember :
// Catching the base exception type is bad, because:
// We can not handle them precisely.
// We can catch other exception by accident.

// Since in above code we have no idea what exception may occure 
// we used System.Exception and we will also catch it at the place from where
// we are calling ReadPersonData(), so we have also thrown it 
// after logging it.