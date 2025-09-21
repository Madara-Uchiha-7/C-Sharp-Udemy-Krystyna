/*
Properties of the Order class
The goal of this exercise is to finish the implementation of the Order class. 
It represents a simple Order made in a store, and it needs to have two properties:

Item (string), which should not be settable at all

Date (DateTime), which should be both gettable and settable. 
Its setter should validate if the given value has the same year as the current year. 
If not, the value of the Date property should not be changed.

Your job is only to add the definitions of those two properties. 
If needed, you can add backing fields as well.
*/
Console.ReadKey();
public class Order
{
    // Declaring a backing _date because I need to add the validation to it.
    private DateTime _date;
    public Order(string item, DateTime date)
    {
        Item = item;
        Date = date; // I guess this capital Date automatically calls below setter
    }
    public string Item{get;}
    public DateTime Date
    {
        get
        {
            return _date;
        }
        set
        {   
            // She has used DateTime.Now.Year at the place of 2024
            if (value.Year == 2024)
            {
                _date = value;
            }
        }
    }
}
