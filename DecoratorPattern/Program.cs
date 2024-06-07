namespace DecoratorPattern;

// Тестування патерну Декоратор
public class Program
{
    public static void Main(string[] args)
    {
        INotifier notifier = new EmailNotifier();
        notifier = new SmsDecorator(notifier);
        notifier = new FacebookDecorator(notifier);
        notifier = new SlackDecorator(notifier);

        notifier.Send("Hello, this is a test message!");

        // Можливі інші комбінації
        INotifier anotherNotifier = new SlackDecorator(new EmailNotifier());
        anotherNotifier.Send("Another test message with Email and Slack!");

        INotifier simpleNotifier = new FacebookDecorator(new SmsDecorator(new EmailNotifier()));
        simpleNotifier.Send("Simple test message with Email and SMS!");
    }
}