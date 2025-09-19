

///
/// We will learn what records and positional records are.
/// We will also understand the benefits of using them.
/// Let's say we want to define a type representing the weather data.
/// It will carry two values: temperature and humidity.
/// So, lets define the class : WeatherData
/// 
/// Properties Temperature and Humidity are immutable because there is not set;
/// 
/// If we do:
/// Console.WriteLine(objectNameOfWeatherData);
/// then
/// class name will get printed as this is the default implementation of the ToString method
/// Lets change it so it will look like:
/// temperature : value, humidity : value

var weatherData = new WeatherData(19.1m, 20);

Console.WriteLine(weatherData);

/// Now we want the objects of this class to support value-based equality.
/// It means I will have to override the Equals method.
/// So we will also have to override GetHashCode.
/// VS can do that for us. Right Click on class name
/// and select Generate Eqauls and GetHashCode in qucik actions option.
/// Select Implement IEquatable<WeatherData> and Generate Operators checkboxes.
/// You will realise that simply adding 
/// Equals(), GetHashCode() and == and != overrde,
/// the class becomes very big.
/// 
/// So, creators of C# realized that this was a common issue.
/// As a solution, they introduced records.
/// 
/// So, we will create the record with the name WeatherData1.
/// Which will be same as WeatherData class.
/// So, add below line to create the record:
/// public record WeatherData1(decimal Temperature, int Humidity);
/// 
/// And that's it.
/// And it does the same thing as over 40 lines we had before.
/// Records are new types joining classes and structs.
/// They are available starting with C# 9.
/// Records are reference types, but they support value-based equality, which means two records carrying
/// identical values will be considered equal even if they differ by reference.
/// Like classes, they support inheritance.
/// 
/// The compiler generates the following methods for records: 
/// An override of the Equals method accepting
/// an object.
/// 
/// The Equals method accepting another instance of this record type.
/// This method implements the IEquatable interface.
/// An override for the GetHashCode method.
/// 
/// Overloads of equality operators i.e. == and !=.
/// 
/// And finally, an override of the ToString method, which prints the names of the properties with their values.
/// 
/// Please notice that all those methods don't use reflection and thanks to that, they are very efficient.
/// 
/// The record we defined here is even more special.
/// It's a positional record, so a record that doesn't even have a body.
/// Later in this video we will learn how to define non-positional records.
/// For now, let's just note that for positional records, the compiler also generates a constructor whose
/// parameters match the parameters of the record declaration(decimal Temperature, int Humidity)) 
/// as well as public properties for each parameter of this constructor.
/// Those properties are readonly for records.
/// Note that parameter starting letter is capital in positional record declaration.
/// This is because they are the name of the properties, not the names of parameters.
/// As we know, the immutability of types is a desired trait.
/// Records are perfect for representing immutable types.
/// To make things even easier, they provide non-destructive mutation with the "with" keyword.

var weatherData1 = new WeatherData1(24.1m, 1);
var weatherPositionalRecord = weatherData1 with { Temperature = 30 }; 


/// 
/// All right, now let's see a regular, nonpositional record. Lets name is WeatherData2.
/// Check the class to see more details.
/// 

public class WeatherData : IEquatable<WeatherData?>
{
    public decimal Temperature { get; }
    public int Humidity { get; }

    public WeatherData(decimal temperature, int humidity)
    {
        Temperature = temperature;
        Humidity = humidity;
    }
    public override string ToString() =>
        $"Temperature : {Temperature}, Humidity : {Humidity}";

    public override bool Equals(object? obj)
    {
        return Equals(obj as WeatherData);
    }

    public bool Equals(WeatherData? other)
    {
        return other is not null &&
               Temperature == other.Temperature &&
               Humidity == other.Humidity;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Temperature, Humidity);
    }

    public static bool operator ==(WeatherData? left, WeatherData? right)
    {
        return EqualityComparer<WeatherData>.Default.Equals(left, right);
    }

    public static bool operator !=(WeatherData? left, WeatherData? right)
    {
        return !(left == right);
    }
}

public record WeatherData1(decimal Temperature, int Humidity);

public record WeatherData2
{
    public decimal Temperature { get; set; }
    public int Humidity { get; }

    public WeatherData2(decimal temperature, int humidity)
    {
        Temperature = temperature;
        Humidity = humidity;
    }
    public void SomeMethod()
    {

    }
    /// As you can see, we need to write a little more code, like explicitly defining the properties and the
    /// constructor.
    /// But as a reward, we can add methods or make the properties writable.
    /// Remember that methods like GetHashCode,
    /// Equals or ToString are still generated by the compiler and we don't need to worry about them.
}