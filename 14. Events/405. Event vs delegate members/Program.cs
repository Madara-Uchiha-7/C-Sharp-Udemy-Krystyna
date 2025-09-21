// We said that variables of delegate types store references to methods.
// Those methods can be added or removed from these variables.
// They can also be invoked.
// The same things are true for events.
// So what is the difference between them?
// Both seem like members of a delegate type, but this is an event.
// For that, check these line below in the code:
// public event EventHandler<PriceReadEventArgs>? PriceRead;
// public EventHandler<PriceReadEventArgs>? PriceReadDelegate;
// Both seem like members of a delegate type, but first is an event.
// Lets use them:
// Check in code:
// goldPriceReader.PriceRead += emailPriceChangeNotifier.Update; 
// goldPriceReader.PriceReadDelegate += emailPriceChangeNotifier.Update;
// One is for event and one is for delegate.
// Difference is, we can not pass null to the events.
// Check in code:
// goldPriceReader.PriceRead(null, null);           -- This will not work.
// goldPriceReader.PriceReadDelegate(null, null);   -- This will work.
// Nulls are passed only to make the compiler not complain about missing arguments.
// For : goldPriceReader.PriceRead(null, null);:->
// As you can see, We can't invoke the event from outside the class it belongs to. 
// But I can invoke the non-event delegate without a problem.
// This is a critical difference.
// Only the class that owns an event can raise it.
// Events are used to send notifications about some action.
// So imagine what would happen if any class could raise them.
// Any code could raise the PriceRead event with any price it wants, triggering invalid notifications
// The event must be public so the subscribers can subscribe to it, but it must only be invokable from
// within the class that owns it.
// And that's what the event keyword enforces.

const int threshold = 30_000;
EmailPriceChangeNotifier emailPriceChangeNotifier = new EmailPriceChangeNotifier(threshold);
PushPriceChangeNotifier psuhPriceChangeNotifier = new PushPriceChangeNotifier(threshold);
GoldPriceReader goldPriceReader = new GoldPriceReader();
// goldPriceReader.PriceRead(null, null);
goldPriceReader.PriceReadDelegate(null, null);

goldPriceReader.PriceRead += emailPriceChangeNotifier.Update;
goldPriceReader.PriceReadDelegate += emailPriceChangeNotifier.Update;
public class PriceReadEventArgs : EventArgs
{
    public decimal Price { get; }
    public PriceReadEventArgs(decimal price)
    {
        Price = price;
    }
}

public class GoldPriceReader
{
    public event EventHandler<PriceReadEventArgs>? PriceRead;
    public EventHandler<PriceReadEventArgs>? PriceReadDelegate;

    public void ReadCurrentPrice()
    {
        int currentGoldPrice = new Random().Next(20_000, 50_000);
        OnPriceRead(currentGoldPrice);
    }

    private void OnPriceRead(decimal price)
    {
        // PriceRead(price);
        PriceRead?.Invoke(this, new PriceReadEventArgs(price));
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
    public void Update(object? sender, PriceReadEventArgs eventArgs)
    {
        if (eventArgs.Price > _notificationThreshold)
        {
            Console.WriteLine(@$"Sending an email saying that 
                                the gold price exceeded {_notificationThreshold} 
                                and is now {eventArgs.Price}\n");
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
    public void Update(object? sender, PriceReadEventArgs eventArgs)
    {
        if (eventArgs.Price > _notificationThreshold)
        {
            Console.WriteLine(@$"Sending an email saying that 
                                the gold price exceeded {_notificationThreshold} 
                                and is now {eventArgs.Price}\n");
        }
    }
}
