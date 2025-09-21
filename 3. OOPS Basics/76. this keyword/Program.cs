// "this" keyword referes to the current instence of the class

// This class will print the date of appointment
// But the Print method takes the object of the MedicalAppointment class.
// Print is called from the MedicalAppointment class.
// Since we are passing this from MedicalAppointment class, to the method Print 
// the current instance of MedicalAppointment will be passed to Print method
// This print method will call the GetDate() of MedicalAppointment Class
// Which will return the private field value of the _date field
class MedicalAppointmentPrinter
{
    public void Print(MedicalAppointment medicalAppointment)
    {
        Console.WriteLine("Appointment will take place on: " + medicalAppointment.GetDate());
    }
}
class MedicalAppointment
{
    // Private varibale/field names starts from _
    private string _patientName;
    private DateTime _date;

    // To create a consturtor there is a shortcut : type ctor and press control + space
    public MedicalAppointment(string patientName, DateTime date)
    {
        // If the field name of the class is same name as the parameter name
        // then we can use this.fieldName to show the difference
        _patientName = patientName;
        _date = date;
    }
    public void Reshedule(DateTime date)
    {
        _date = date;
        MedicalAppointmentPrinter printer = new MedicalAppointmentPrinter();
        printer.Print(this);
    }
    public DateTime GetDate() => _date;
}