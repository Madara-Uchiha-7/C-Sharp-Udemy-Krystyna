///
/// Dictionary is a collection of key-value pairs.
///
///
/// Dictionaries, like lists, are generic collections, but unlike lists, they are parameterized by two types:
/// one for the keys and one for the values.
/// Those types don't need to be the same, but in this case they will be, because in this dictionary the
/// key will be the country's name i.e a string, and the value will be the currency's name which is also a string.
/// 
var countryToCurrencyMapping = new Dictionary<string, string>();

// The Add method takes two parameters: the key and the value.
//
countryToCurrencyMapping.Add("USA", "USD");
countryToCurrencyMapping.Add("India", "INR");
countryToCurrencyMapping.Add("Spain", "EUR");

// We can access the value at the given key using the indexer.
//
Console.WriteLine(countryToCurrencyMapping["India"]);

// It is a bit similar to accessing the list item stored at a given index, but we pass a key instead of
// a numeric index.

// We can not only use the indexer to get the value at a given key, but also to set it.
//
countryToCurrencyMapping["Poland"] = "PLN";

// An important thing to understand about Dictionaries is that each key in the Dictionary must be unique.
// An exception wull be thrown with the error, saying "An item with the same key has already been added" if you try to 
// the same key using the Add() method.
// Please be aware that when using an indexer to set a value, the exception will not be thrown because
// the indexer overrides the value at a given key if it already exists.
// i.e. below will not throw the error even when "Poland" exist as the key.
// 
countryToCurrencyMapping["Poland"] = "Update in PLN";

// This makes the indexer different from the Add method, which tries to add a new key-value pair to the
// Dictionary.

// Values can be same.

// When we were using lists, we often used the collection initializer instead of adding new items one by one.
// This is how the collection initializer looked for lists.
// 
List<int> numbers = new List<int> { 1, 2, 3, 4 };

// For dictionaries,
// it is a bit different since each entry in a dictionary is a pair of a key and a value.
// We can initialize the dictionaries in two ways.
//
// On the left, we have the keys and on the right, the corresponding values.
// 
var anotherCountryToCurrencyMapping = new Dictionary<string, string>
{
    ["USA"] = "USD",
    ["India"] = "INR",
    ["Spain"] = "EUR"
};

// In older code, you may see an alternative syntax like this.
//
var anotherOlderCountryToCurrencyMapping = new Dictionary<string, string>
{
    { "USA", "USD" },
    {"India", "INR" },
    {"Spain", "EUR" } 
};

// Both have the same effect.
// So simply choose the one that you like better.

// If key is not present and if you try to get the value of that key
// then error will come.
// Below will throw error :
// Console.WriteLine(anotherOlderCountryToCurrencyMapping["AbraKaDabra"]); 

// To avoid such error, use the ContainsKey method.

if (countryToCurrencyMapping.ContainsKey("AbraKaDabra"))
{
    Console.WriteLine(countryToCurrencyMapping["AbraKaDabra"]);
}

// We said that each entry in a dictionary is a key-value pair.
// So when we iterate a Dictionary with a foreach loop, the loop variable is also a key-value pair.
// We will print all items in this dictionary to the console.

// We will see type of country is KeyValuePair of string string.
// 

foreach (KeyValuePair<string, string> country in countryToCurrencyMapping)
{
    Console.WriteLine(country.Key + " : " + country.Value);
}



// We also can not add the value to the key which is not present.