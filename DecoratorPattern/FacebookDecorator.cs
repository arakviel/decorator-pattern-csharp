namespace DecoratorPattern;

internal class FacebookDecorator : NotifierDecorator
{
    public FacebookDecorator(INotifier notifier) : base(notifier) { }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"Posting to Facebook: {message}");
    }
}