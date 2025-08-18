// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

// Interfaces are used to define a base type for the types exposing
// methods with same signature.
// We use interface for those classes which does not share the is-a relationship
// but share the same behaviour.

namespace Polymorphism.Flyables
{
    // Letter I is the naming convention.
    // Use it when naming the interfaces.
    public interface IFlyable
    {
        // In interfaces we only declare methods not the body of methods
        // and each type implementing the interface will have the override them.
        // When overriding the method in the child class,
        // signature i.e. type, paramaters etc should be same as Interface methods.

        // No access modifier is defined to this becasuse
        // an interface defines what methods the users of the types implementing
        // it will able to call.
        // Means those methods have to be public. 
        // Even if the class contains a method with the signature defined in an 
        // interface, but this method is not public, then we do not consider 
        // the contract(override method with same signature) definde by interface met.
        // So these overrided methods in the child class has to be public.
        void Fly();
        // Methods defined in the interface are always implicitely virtual.
        // So dont add virtual keyword manually here.
        // Interfaces can not be instantiated.
        // They are too abstract for that.

    }
    public class Bird : IFlyable
    {
        public void Tweet() => Console.WriteLine("Tweet, Tweet!");

        public void Fly() => Console.WriteLine("Flying using its wings.");
    }
    
    public class Kite : IFlyable
    {
        public void Fly() => Console.WriteLine("Flying carried by wind.");
    }

    public interface IFueable
    {
        void Fuel();
    }

    public class Plane : IFlyable, IFueable
    {
        public void Fly() => Console.WriteLine("Flying using Jet.");

        public void Fuel() => Console.WriteLine("Filling.....");
    }

    // The code in MainClass
    // was not working when I put it in namespace directly.
    // So, I understood that such code logic, like methods, fields, properties ...
    // should be kept in class or Interface etc. i.e. in some
    // container except puting it in namespace
    class MainClass
    {
        // We know that, interfaces can not be instantiated.
        // Know that we can still use them as the General Types as we did for inheritance
        // using the List Type
        // E.g.:
        List<IFlyable> flyables = new List<IFlyable>
        {
            new Plane(),
            new Kite()
        };
    }
}

// 99% interfaces does not contain anything else but the declarations
// of the methods and properties which, remember, are also more like methods than fields.
// Why 99% ?
// The C# 8 : added a feature called default implemenations in interfaces.
// It is considered as the bad change or addition by many C# devs.

// Read more in:
// https://www.talkingdotnet.com/default-implementations-in-interfaces-in-c-sharp-8/
// https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/interface-implementation/default-interface-methods-versions