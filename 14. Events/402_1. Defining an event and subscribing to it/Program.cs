// Continuation of the last lecture.
// All right, back to events.
// Let's implement the same logic we had, but this time using events.
// Classes are from lecture 399.

const int threshold = 30_000;
EmailPriceChangeNotifier emailPriceChangeNotifier = new EmailPriceChangeNotifier(threshold);
PushPriceChangeNotifier psuhPriceChangeNotifier = new PushPriceChangeNotifier(threshold);
GoldPriceReader goldPriceReader = new GoldPriceReader();
goldPriceReader.PriceRead += emailPriceChangeNotifier.Update;
goldPriceReader.PriceRead += psuhPriceChangeNotifier.Update;
for (int i = 0; i < 3; i++)
{
    goldPriceReader.ReadCurrentPrice();
}
Console.ReadKey();
Console.ReadKey();

// Variables of below defined delegate type can store any void method or methods that take a
// single decimal parameter. In the context of events
// those methods will come from the Observers and they will be executed when
// the event of reading the latest gold price happens.
// The GoldPriceReader will own an event of this delegate type.
public delegate void PriceRead(decimal price);
public class GoldPriceReader
{
    // Declared an event belonging to the Gold Price Reader class.
    // An event is always of a delegate type.
    // This event is a member in this class that can hold a reference
    // to a method or methods with particular parameters and return type.
    // So whatever is stored in this event will be method or methods taking a decimal
    // and returning nothing.
    // Please notice it is public.
    // This is important because other classes, the observers of this class,
    // must be able to access it and attach their methods to it.
    public event PriceRead? PriceRead; 

    private int _currentGoldPrice;

    public void ReadCurrentPrice()
    {
        _currentGoldPrice = new Random().Next(20_000, 50_000);
    }
}

public class EmailPriceChangeNotifier
{
    private readonly decimal _notificationThreshold;

    public EmailPriceChangeNotifier(decimal notificationThreshold)
    {
        _notificationThreshold = notificationThreshold;
    }

    // It takes the current price of gold, and if it is above this threshold, it sends the email to the user.
    public void Update(decimal price)
    {
        if (price > _notificationThreshold)
        {
            Console.WriteLine(@$"Sending an email saying that 
                                the gold price exceeded {_notificationThreshold} 
                                and is now {price}\n");
        }
    }
}

public class PushPriceChangeNotifier
{
    private readonly decimal _notificationThreshold;
    public PushPriceChangeNotifier(decimal notificationThreshold)
    {
        _notificationThreshold = notificationThreshold;
    }
    public void Update(decimal price)
    {
        if (price > _notificationThreshold)
        {
            Console.WriteLine(@$"Sending an email saying that 
                                the gold price exceeded {_notificationThreshold} 
                                and is now {price}\n");
        }
    }
}
