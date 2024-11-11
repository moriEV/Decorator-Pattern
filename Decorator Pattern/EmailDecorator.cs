using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    internal class EmailDecorator:Decorator
    {
        public EmailDecorator(INotifier notifier, Admin admin):base( notifier,admin)
        {

        }
        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"to {_admin.Email}:{message}");
        }
    }
}
