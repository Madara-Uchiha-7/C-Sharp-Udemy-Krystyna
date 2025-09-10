// --Notes by: Chinmay Kumar Borkar
// -- Linkedin: https://www.linkedin.com/in/chinmay-borkar-1042931a6/
// --github   : https://github.com/Madara-Uchiha-7
// --------------------------------------------------------------------

const int Counts = 10000;
List<string> list = new List<string>(Counts);
for (int i = 0; i < Counts; i++)
{
    list.Add("AAA");
}
// We have a list to which we add 10,000 strings like this.
// What interests me is how much memory consumption grows between the moment the list is created and when
// it is already filled with those strings.

// There will be 10,000 new strings created.
// Each consists of five chars and each car is 16 bits,
// so 2 bytes long. 
// This should give at least 10,000 * 5 * 2 new bytes being occupied, which is 100,000 bytes.
// Lets add the code that will show us how much the memory consumption grows.
// Below is Teachers repo code I copied:

const int Count = 10000;
TestStringsMemoryConsumption(Count);
TestCharArraysMemoryConsumption(Count);
TestVariousStringsMemoryConsumption(Count);
Console.ReadKey();

// Here is the TestStringsMemoryConsumption method.
// 
void TestStringsMemoryConsumption(int count)
{
    var list = new List<string>(count);
    GC.Collect(2, GCCollectionMode.Default, true);
    var memoryBefore = GC.GetTotalMemory(false);

    // Inside it has the loop we saw before, but also
    // it measures the memory consumption before and after the loop is finished.
    // Before the loop runs, I force the full garbage collection so other unused objects don't affect our test.
    // So [GC.Collect(2, GCCollectionMode.Default, true);] we clean the memory.
    // [var memoryBefore = GC.GetTotalMemory(false);] here we measue the memory consumption before loop runs.
    for (int i = 0; i < Count; ++i)
    {
        list.Add($"aaaaa");
    }

    // We clean the memory again and measure the memory one more time.
    GC.Collect(2, GCCollectionMode.Default, true);
    var memoryAfter = GC.GetTotalMemory(false);
    // Then we print the difference in bytes.
    Console.WriteLine(
        "(strings) difference in bytes is " + (memoryAfter - memoryBefore));
    // We must be aware that the method returning the number of occupied bytes only returns its approximation.
    // So this result might not be perfectly accurate.
    // Still, it is definitely much less than we expected.
    // We expected at least 100,000 new bytes to be occupied. Before we understand what happens
    // let's run another test. TestCharArraysMemoryConsumption
    // It will be very similar to what we have here, but instead of strings, this list will store char arrays
    // of length five.
    // Memory consumption for arrays of char.
    // Again, this result may not be accurate and our estimate was very rough, but it definitely shows that
    // when we use char arrays instead of strings
    // memory consumption grows significantly.
    // But why is that so?
    // Well, strings have a very special optimization enabled.
    // They can be interned. String
    // interning means that if multiple string variables hold strings that are known to be equal, the runtime
    // actually points the reference to a single string object, thereby saving memory.
    // So in the first method where it seemed like we created 10,000 strings, we didn't.
    // There was only one string in memory, and all references in the list pointed to this single object.
    // To prove this is the case, let's make each string in this list unique.
    // It is done in TestVariousStringsMemoryConsumption().
    // And suddenly we see how much memory consumption grew.
    // Now the string interning cannot be used because all strings in this list are different.
    // We now see that the memory consumption for both of those methods is actually quite similar,
    // i.e. TestCharArraysMemoryConsumption and TestVariousStringsMemoryConsumption.

    string text = "abc";
    string text2 = "abc";
    Console.WriteLine(object.ReferenceEquals(text, text2)); //It will return true.
    // Please be aware that string interning optimization wouldn't work if strings were mutable.
    // String interning takes advantage of the flyweight design pattern which we will learn about in the next
    // lecture.
}

void TestCharArraysMemoryConsumption(int count)
{
    var list = new List<char[]>(count);
    GC.Collect(2, GCCollectionMode.Default, true);
    var memoryBefore = GC.GetTotalMemory(false);

    for (int i = 0; i < count; ++i)
    {
        list.Add(new char[] { 'a', 'a', 'a', 'a', 'a' });
    }
    GC.Collect(2, GCCollectionMode.Default, true);
    var memoryAfter = GC.GetTotalMemory(false);
    Console.WriteLine(
        "(char arrays) difference in bytes is " + (memoryAfter - memoryBefore));
}

void TestVariousStringsMemoryConsumption(int count)
{
    var list = new List<string>(count);
    GC.Collect(2, GCCollectionMode.Default, true);
    var memoryBefore = GC.GetTotalMemory(false);

    for (int i = 0; i < Count; ++i)
    {
        list.Add($"aaaaa{i}"); //noe wach string will be different, so they won't be interned
    }

    GC.Collect(2, GCCollectionMode.Default, true);
    var memoryAfter = GC.GetTotalMemory(false);
    Console.WriteLine(
        "(various strings) difference in bytes is " + (memoryAfter - memoryBefore));
}