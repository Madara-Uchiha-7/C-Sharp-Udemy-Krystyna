///
/// We will use the DateTime type to see how object-oriented programming can be used in
/// practice.
/// 
/// We will also understand what a constructor is.
/// 
/// Let see e.g.
/// We could need to represent someone's date of birth or the date of the subscription to some service.
/// We could also use dates to store information about the user's activity.
/// For example, to remember when was the last time the user logged in to our application.
/// As you can see, the use cases for using dates are endless.
/// It would be very convenient to have a DateTime type that we could use to represent dates and times.
/// 
/// Since dates are so commonly used in programming, the creators of the C# standard library already
/// created the DateTime type.
/// DateTime is a struct not a class.
/// As we said before, the differences between classes, structs, and records are rather technical.
/// On the conceptual level, they are basically the same.
/// 
/// 

var internationalPizzaDay1 = new DateTime(2024, 2, 9);
// We created an object representing the date of the International Pizza Day of 2022.
// We used the new keyword to create it and we followed it with the type's name i.e. DateTime
// Then we have parentheses.
// It's a special method called a constructor used specifically to create new class instances.
// In this case, the constructor takes three integer parameters: the year, month, and the day of the date
// we want to represent.
// We could also pass more parameters representing hours, minutes, seconds, etc.
// e.g. 
var internationalPizzaDay2 = new DateTime(2024, 2, 9, 12, 34, 11);


// As you may recall, we used constructors before when we created new instances of the List class.
// But in those cases we use the constructor with zero parameters. i.e.
// new List<int>();

// This object is a container for date-related data, specifically three integers representing the year,
// month and day.
Console.WriteLine(internationalPizzaDay1.Day); ;
Console.WriteLine(internationalPizzaDay1.Month);
Console.WriteLine(internationalPizzaDay1.Year);
Console.WriteLine(internationalPizzaDay1.DayOfWeek);


// In above code internationalPizzaDay1 and internationalPizzaDay2 are objects/instances of
// type DateTime.

// Lets use the method of this type.
var internationalPizzaDay3 = internationalPizzaDay2.AddYears(1);
Console.WriteLine(internationalPizzaDay3.Day); ;
Console.WriteLine(internationalPizzaDay3.Month);
Console.WriteLine(internationalPizzaDay3.Year);
Console.WriteLine(internationalPizzaDay3.DayOfWeek);