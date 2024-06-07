namespace DecoratorPattern;

// Декоратор для відправки через SMS
internal class SmsDecorator : NotifierDecorator
{
    public SmsDecorator(INotifier notifier) : base(notifier) { }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"Sending SMS: {message}");
    }
}
