// Instead of having our own PriceRead delegate for the event
// we can use the EventHandler delegate predefined in C#.
// Let's see the signature of this delegate.

// object? sender carries the information about the object that raised that event and
// also event arguments.
// EventArgs type itself does not carry any data, but it can be used as a base class for more specific
// event arguments.
// public delegate void EventHandler(object? sender, EventArgs e);

// The EventHandler delegate also has a generic counterpart that allows us to specify different event
// arguments than simple EventArgs.
// The type passed here does not have to be, but usually is, derived from the base EventArgs type.
// In our case, the argument of an event is the gold price that has been read.
// public delegate void EventHandler<TEventArgs>(object? sender, TEventArgs e);

// Let's create our own type derived from EventArgs.


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

// public delegate void PriceRead(decimal price);
public class PriceReadEventArgs : EventArgs
{
    public decimal Price { get; }
    public PriceReadEventArgs (decimal price)
    {   
        Price = price; 
    }
}

public class GoldPriceReader
{
    public event EventHandler<PriceReadEventArgs>? PriceRead;

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


// With this approach, we only use a single delegate type, the EventHandler,
// instead of defining many different delegates designed for various events.
// Also in Windows Forms or Windows Presentation Foundation, all user actions
// like clicking on a button or closing a window can trigger events, and those events are defined
// with the EventHandler delegate.
// In those use cases
// the sender argument is often used by the subscribers, which we didn't need here.
// 