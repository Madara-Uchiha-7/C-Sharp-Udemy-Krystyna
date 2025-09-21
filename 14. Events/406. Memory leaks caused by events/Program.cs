
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

