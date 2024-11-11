using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    internal class FBDecorator:Decorator
    {
        public FBDecorator(INotifier notifier,Admin admin) : base(notifier,admin) { }
        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"to {_admin.FacebookID}:{message}");
        }
    }
}
