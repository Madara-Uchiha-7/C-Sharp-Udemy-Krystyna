// Adding multiple methods with the same name in the same class is method overloading
// Only return type is not enough for determining diff in method overloading
// 1st thing to do always, write ReadKey
Console.ReadKey();

class MedicalAppointment
{
    // Private varibale/field names starts from _
    private string _patientName;
    private DateTime _date;

    // To create a consturtor there is a shortcut : type ctor and press control + space
    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName; 
        _date = date;
    }

    // Reshedules whole date
    public void Reshedule(DateTime date)
    {
        _date = date;
    }

    // Reshedules month and day only
    // Same method name but different parameters 
    public void Reshedule(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day); 
    }

}
