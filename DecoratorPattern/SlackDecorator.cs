namespace DecoratorPattern;

// Декоратор для відправки через Slack
internal class SlackDecorator : NotifierDecorator
{
    public SlackDecorator(INotifier notifier) : base(notifier) { }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"Sending to Slack: {message}");
    }
}