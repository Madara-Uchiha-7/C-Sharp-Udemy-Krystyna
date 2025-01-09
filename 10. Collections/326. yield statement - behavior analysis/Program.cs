/// For below code, it will go into the method for only one time.
/// If we only call the metohd like : GenerateEvenNumbers()
/// Then it will not call anything.
int firstNumber = GenerateEvenNumbers().First();

/// This below line's secondNumbers will not call the method 
/// GenerateEvenNumbers(). Its like it will point to the method.
/// Sort of like reference variable points to the class object but does not 
/// do anything till we call any operation from that reference.
/// You will know why below line does not call the function in next lectures.
IEnumerable<int> secondNumbers = GenerateEvenNumbers();
/// Now the below line's secondNumbers.Take(3) will hit the method.
/// It will go in method, will take 1st even then will print it using below for
/// then will again go in method, will take 2nd even then will print it using 
/// below for loop. Same goes for the 3rd even number.
foreach (int evenNumbers in  secondNumbers.Take(3))
{
    Console.WriteLine(evenNumbers);
}

Console.ReadKey();

IEnumerable<int> GenerateEvenNumbers()
{
    for (int i = 0; i < int.MaxValue; i = i + 2)
    {
        yield return i;
    }

}