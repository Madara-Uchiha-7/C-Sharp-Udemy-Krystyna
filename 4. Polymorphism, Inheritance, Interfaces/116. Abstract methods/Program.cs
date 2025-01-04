///
/// Abstract methods can be defined only in the abstract classes.
/// These methods does not have the implemenatations.
/// That is their bodies are empty, so there will be no {}
/// and there will be ; after the ()
/// All the abstract methods are implicitly virtual. So adding virtual keyword will cause error.
/// It is compulsory to derive these methods in the non-abstract derived classes.
/// So, we need to override these methods in all child non-abstract classes.
/// We can skip the overriding of the abstract method if the child class
/// is also abstract.


public class Pizza
{

}
public abstract class Ingredient
{
    // Since this method will get overriden in all the child classes,
    // it is pointless to give the body to them.
    // Also since class is abstract, we cant create the obj, so we can not 
    // call this method which does not have the body.
    public abstract string Prepare();

    // It seems it is allowed to define method which is not abstract in the
    // abstarct class. But even though it is not abstract, i.e. not implicitly
    // virtual, I am facing the error in child classes and it goes away after I
    // override this method in the child classes without the override keyword.
    public string MethodWithoutAbstract()
    {
        return "";
    }

}
public class Cheese : Ingredient
{
    public override string Prepare()
    {
        return "";
    }
    /* public string MethodWithoutAbstract()
    {
        return "";
    }*/
}
public class Mozzarella : Ingredient
{
    public string prepare()
    {
        return "";
    }
}
public class Chadder : Ingredient
{
    public string prepare()
    {
        return "";
    }
}

// Virtual methods
///
/// Must have the implimentation.
/// Overriding is optional.
/// 
/// 
/// Abstract Methods
/// Can not have the implementation.
/// Overriding is obligatory.
///