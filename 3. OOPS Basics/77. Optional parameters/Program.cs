Console.ReadKey();

MedicalAppointment appointmentTwoWeeksFromNow = new MedicalAppointment("Bob", 14);
MedicalAppointment appointmentOneWeeksFromNow = new MedicalAppointment("Sam");
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
    /*
     * To Avoid the duplcation we used this keyword and called another constructor 
     * from below constructor, the there is another way called optional parameter
     
    // Set date to next week by default if no date is provided
    public MedicalAppointment(string patientName) :
        this(patientName, 7)
    {
    }
    public MedicalAppointment(string patientName, int daysFromNow)
    {
        _patientName = patientName;
        // "Now" will get the current date and time
        _date = DateTime.Now.AddDays(daysFromNow);
    }
    */

    // Dafault value of optional parameter must be compile time constant
    // They must appear after all the required parameters
    // It is possible to have the mutiple optional parameters
    public MedicalAppointment(string patientName, int daysFromNow = 7)
    {
        _patientName = patientName;
        // "Now" will get the current date and time
        _date = DateTime.Now.AddDays(daysFromNow);
    }
    /* Assume below scenario: 
     
       public MedicalAppointment(string patientName = "Son", int daysFromNow = 7)
       {
            _patientName = patientName;
            // "Now" will get the current date and time
            _date = DateTime.Now.AddDays(daysFromNow);
       }

       public MedicalAppointment(string patientName)
       {
            _patientName = patientName;
       }

       MedicalAppointment test = new MedicalAppointment("Sam");
       // The above statement will call the 2nd constructor which has no optional
       // parameters. In case of ambuguity the methods with no optional 
       // parameters are called
       // If you are using the 1st constructor i.e. which has optional parameter
       // then in such cases dont define 2nd constructor 

     */
}
