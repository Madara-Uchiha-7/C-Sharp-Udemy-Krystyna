// -- Notes by : Chinmay Kumar Borkar
// -- Linkedin : https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// -- github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

using System.Diagnostics; // For Stopwatch type

/*Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();*/
// Above is same as below
// Below create the stopwatch instance and starts it right away.
Stopwatch stopwatch = Stopwatch.StartNew();
IEnumerable<int> ints = CreateCollectionOfRandomLength<int>(1000000);
stopwatch.Stop();
Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms.");
Console.ReadKey();
IEnumerable<T> CreateCollectionOfRandomLength<T>(int maxLength) where T : new()
{
    int length = new Random().Next(maxLength + 1);
    List<T> result = new List<T>(length);
    for (int i = 0; i < length; i++)
    {
        // Since we are adding the values in the list one by one
        // the list will keep on resizing and it is a heavy opeartion.
        // For e.g. for length 100 the list will resize for 5 times.
        // When add the 1st time the array is size it set to 4.
        // The 5th item will cause resize by meaking the size 8.
        // The size will become 16, 32, 64 and then 128. 
        // 4->8, 8->16, 16->32, 32->64, 64->128
        // To improve this will pass the length to the constructor of the list.
        // So no re-sizing will happen for even once.
        // So, always use this List constructor if you know the list size.
        // Ofcourse list can still be resized if we add more than specified size.
        result.Add(new T());
    }
    return result;
}

///
/// Stopwatch is not perfect.
/// So performance measurements shold be done many times in a row and average time of
/// execution should be calculated.
/// Also make sure that the environment in which the code runs is stable so it 
/// does not affect the execution time.
///