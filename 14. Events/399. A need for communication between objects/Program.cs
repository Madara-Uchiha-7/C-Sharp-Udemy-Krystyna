// In this lecture, we will discuss the need for some software components to send notifications to one
// another.
// This will help us better understand the observer design pattern and the mechanism of events.
// Many actions in our programs should only be triggered as a reaction to some event.
// 

// Whenever GoldPriceReader method runs, we want to notify to other classes about the current gold price that has
// been read.
// We need to run the Update method from EmailPriceChangeNotifier and PushPriceChangeNotifier the classes.

// The price is read in the ReadCurrentPrice method.
// So this is where we will pass this price as an argument to the Update methods from both notifier classes.
// This means the GoldPriceReader class will need to have references to notifier objects.
// We added two references of EmailPriceChangeNotifier and PushPriceChangeNotifier in GoldPriceReader.
// and we added constructor of GoldPriceReader and initialized value in it.
// We can now call the notification Update method in ReadCurrentPrice(), so we have added that.
// Lets make sure that all of this is working:
const int threshold = 30_000;
EmailPriceChangeNotifier emailPriceChangeNotifier = new EmailPriceChangeNotifier(threshold);
PushPriceChangeNotifier psuhPriceChangeNotifier = new PushPriceChangeNotifier(threshold);
GoldPriceReader goldPriceReader = new GoldPriceReader(emailPriceChangeNotifier, psuhPriceChangeNotifier);
for (int i = 0; i < 3; i++)
{
    goldPriceReader.ReadCurrentPrice();
}
Console.ReadKey();

public class GoldPriceReader
{
    private int _currentGoldPrice;

    private readonly EmailPriceChangeNotifier _emailPriceChangeNotifier;
    private readonly PushPriceChangeNotifier _pushPriceChangeNotifier;
    public GoldPriceReader(
        EmailPriceChangeNotifier emailPriceChangeNotifier, 
        PushPriceChangeNotifier pushPriceChangeNotifier)
    {
        _emailPriceChangeNotifier = emailPriceChangeNotifier;
        _pushPriceChangeNotifier = pushPriceChangeNotifier;
    }

    public void ReadCurrentPrice()
    {
        _currentGoldPrice = new Random().Next(20_000, 50_000);
        _emailPriceChangeNotifier.Update(_currentGoldPrice);
        _pushPriceChangeNotifier.Update(_currentGoldPrice);
    }
}

// EmailPriceChangeNotifier:
// Its job is to send an email to the user of this app
// if the current gold price is above the threshold that was given in the constructor.
// 
public class EmailPriceChangeNotifier
{
    private readonly decimal _notificationThreshold;

    public EmailPriceChangeNotifier (decimal notificationThreshold)
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
