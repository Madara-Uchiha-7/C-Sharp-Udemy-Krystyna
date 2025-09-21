// Adding multiple methods with the same name in the same class is method overloading

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

    // Overloaded Constructor : Sets defualt date if not mentions
    // Sets it to seven day from current day
    public MedicalAppointment(string patientName):
        this(patientName, 7) // This will call the below constructor
    {
        // Since the logic in this constructor and below one is the same
        // we will call below constructor from this constructor
        // in this context "this" keywords referes to another constructor
    }
    // Overloaded Constructor : Sets date to current day + mentioned number
    public MedicalAppointment(string patientName, int daysFromNow)
    {
        _patientName = patientName;
        // "Now" will get the current date and time
        _date = DateTime.Now.AddDays(daysFromNow);
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
