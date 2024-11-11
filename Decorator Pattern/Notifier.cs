using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class Notifier:INotifier
    {
        private Admin Admin;
        public Notifier(Admin admin)
        {
            Admin = admin;
        }
        public void Send(string message)
        {
            Console.WriteLine($"Важное сообщение");
        }
    }
}
