// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// Sometimes we want to prevent the type from being inherited.
// C# allows us to do so using sealed modifier.
// Methods :
// Only virtual and overriden methods can be sealed.
public abstract class AnimalKingdom
{
    public abstract int NumberOfLegs();
}
public sealed class Duck :AnimalKingdom
{
    public override int NumberOfLegs() => 2;
}
public class Dog : AnimalKingdom
{
    public sealed override int NumberOfLegs() => 4;
}

public class DogsTypes : Dog
{
    // Since the class Dog has sealed its parent method NumberOfLegs(),
    // the child of Dog class can not use it using override keyword.
}

// string class which is default class given to us is 
// a sealed class.