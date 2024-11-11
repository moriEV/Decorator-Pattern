using Decorator_Pattern;

internal class Program
{
    private static void Main(string[] args)
    {
        var admins = new List<Admin>
        {
            new Admin("admin1@example.com","+88005553535","admin1"),
            new Admin("admin2@example.com",null,null),
            new Admin(null,null,"admin3"),
            new Admin(null,"+88005553535",null)
        };
        foreach (var admin in admins)
        {
            INotifier notifier = new Notifier(admin);
            if (!string.IsNullOrEmpty(admin.Email)) 
            {
                notifier = new EmailDecorator(notifier,admin);
            }
            if (!string.IsNullOrEmpty(admin.PhoneNumber))
            {
                notifier = new SMSDecorator(notifier,admin);
            }
            if (!string.IsNullOrEmpty(admin.FacebookID))
            {
                notifier = new FBDecorator(notifier,admin);
            }
            notifier.Send("Краснов, почини сервера");
        }
    }
}