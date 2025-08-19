///
/// Metadata is the data which provides the information about some data.
/// For e.g. taka a table in sql, in that table rows are the data and column names 
/// and relation of that table to other tables will be the metadata.
/// In programming metadata is the types used in the application.
/// Attributes add metadata to a type.
/// In other words they are a way to add information about a type or method 
/// to exiting metadata which decribes the type or method which we can read 
/// from the Type object.
/// Lets consider a simple Person class.
///
/*
public class Person
{
    public string Name { get; }
    public int YearOfBirth { get; }

    public Person(string name, int yearOfBirth)
    {
        Name = name;
        YearOfBirth = yearOfBirth;
    }
    public  Person(string name) => Name = name;
}
*/
///
/// Metadata is the data which provides the information about some data.
/// For e.g. taka a table in sql, in that table rows are the data and column names 
/// and relation of that table to other tables will be the metadata.
/// In programming metadata is the types used in the application.
/// Attributes add metadata to a type.
/// In other words they are a way to add information about a type or method 
/// to exiting metadata which decribes the type or method which we can read 
/// from the Type object.
/// Lets consider a simple Person class.
///
///
/// So, metadata constains the information that this class is nameed "Person",
/// it is public, non static, non sealed(What is this non sealed) etc.
/// It contains only 2 get only public properties called Name and YearOfBirth.
/// It has one public constructor taking 2 string parameters and one taking 
/// one parameter.
/// The actual data stored in an instance of this class would be the sting representing
/// the name and int.
/// We can access all the class's metadata using the reflection.
/// Sometimes we want to add extra metadata to a type or a method and this
/// is what attributes are for.
/// 
/// Lets consider one example: We want to have a common way of validating some data
/// in the application. No matter the type we want to be able to specify that some members, for e.g. string,
/// must have certain length.
///


Person validPerson = new Person("John", 1981);
Dog invalidDog = new Dog("R");

Validator validator = new Validator();
Console.WriteLine(validator.Validate(validPerson) ? "Person is valid" : "Person is invalida");
Console.WriteLine(validator.Validate(invalidDog) ? "Dog is valid" : "Dog is invalid");
Console.ReadKey();

public class Dog
{
    [StringLengthValidate(2,10)] // Custom Attribute is created for metadata
    public string Name { get; } // Length must be in 2 and 10
    public Dog(string name) => Name = name;
}
public class Person
{
    [StringLengthValidate(2, 25)] // Custom Attribute is created for metadata
    public string Name { get; } // Length must be in 2 and 25
    public int YearOfBirth { get; }

    public Person (string name, int yearOfBirth)
    {
        Name = name;
        YearOfBirth = yearOfBirth;
    }
}

// All the attributes must be derived from the Attribute base class.
// Also name of our attribute class should end with Attribute
// When we use this attribute, the postfix "Attribute" of the 'Attribute' class name is omited. 
// We can also define what the attribute can be applied to. For e.g. in StringLengthValidateAttribute example, we want it to be
// applied to the properties. To enforce that we must actually use a built-in attribute called AttibuteUsage.

[AttributeUsage(AttributeTargets.Property)]
class StringLengthValidateAttribute : Attribute
{
    public int Min { get; }
    public int Max { get; }

    public StringLengthValidateAttribute(int min, int max)
    {
        Min = min; 
        Max = max;
    }
}

class Validator
{ 
    public bool Validate(object obj)
    {
        Type type = obj.GetType();
        IEnumerable<System.Reflection.PropertyInfo> propertiesToValidate = type
            .GetProperties()
            .Where(property => Attribute.IsDefined(
                property, typeof(StringLengthValidateAttribute)));
        /// Using Where and Attribute.IsDefined : 
        /// We select only those properties for which this(StringLengthValidateAttribute) attribute is defined.
        
        foreach(System.Reflection.PropertyInfo property in propertiesToValidate)
        {
            object? propertyValue = property.GetValue(obj);

            // Below if: Means Dev has mistakenly added the attribute to the wrong property type.
            if (propertyValue is not string)
            {
                throw new InvalidOperationException(
                    $"Attribute {nameof(StringLengthValidateAttribute)}" +
                    $" can only be applied to strings.");
            }

            string value = (string)propertyValue;

            // GetCustomAttributes : Will give the the attribute object.
            // It takes the type of attribute and a Boolean saying if we should check the attributes that have been inherited
            // from the base type.
            // This returns the collection and we took the first element from it.
            StringLengthValidateAttribute attribute = (StringLengthValidateAttribute)property.GetCustomAttributes(
                typeof(StringLengthValidateAttribute), true).First();

            if (value.Length < attribute.Min || value.Length > attribute.Max)
            {
                Console.WriteLine($"Property {property.Name} is invalid. "+
                    $"Value is {value}");
                return false;
            }
        }
        return true;
    }
}
///
/// To add an attribute to a member or type, we simply must write its name in the brackets above the type or member we want to
/// add it to. 
/// We can also define what the attribute can be applied to. For e.g. in StringLengthValidateAttribute example, we want it to be
/// applied to the properties. To enforce that we must actually use a built-in attribute called AttibuteUsage.
///


