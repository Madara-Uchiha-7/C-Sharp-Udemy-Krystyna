
using System.Collections.ObjectModel;

/// Example from last lecture. Lets make it readonly.
/// 
/// We can easily make this collection readonly by changing the return type of the method ReadPlanets() to IEnumerable<string>.
/// Because IEnumerable<T> only has one method which does not modify the code.
/// But under the hood it is still the List. One may cast it back to List. Like List<string> asList = (List<string>)planets;
/// So, IEnumerable<T> does not make it a truly readonly
/// To make it truly readonly, we can use the type ReadOnlyCollection<T>
///
IEnumerable<string> planets = ReadPlanets();
// List<string> copyPlanets = (List<string>) planets; //Will not work at run time because ReadPlanets returns
// ReadOnlyCollection<string>.
// If you try to change the cast to (ReadOnlyCollection<string>), the below line will fail.
// planets.Clear();
// ReadOnlyCollection<T> indexer also does not have the setter to modify the planets.
Console.ReadKey();

IEnumerable<string> ReadPlanets()
{
    List<string> result = new List<string>()
    {
        "Alderaan",
        "Coruscant",
        "Bespin"
    };
    return new ReadOnlyCollection<string>(result); // Use System.Collections.ObjectModel; for ReadOnlyCollection<T>
}
// Return type is IEnumerable<string> but we are returning ReadOnlyCollection<string> this works because I think
// it extends IList<T> which also extends IEnumerable<T>.

///
/// ReadOnlyCollection implements IList also which also has the Add() which again goes against the "I" from
/// SOLID principles. ReadOnlyCollection's Add implementation again throws the 
/// ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);

/// If you are working with the dictionaries then use ReadOnlyDictionary.
/// 
Dictionary<string, int> dict = new Dictionary<string, int>();
ReadOnlyDictionary<string, int> readOnlyDict = new ReadOnlyDictionary<string, int>(dict);