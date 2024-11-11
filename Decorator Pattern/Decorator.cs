using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public abstract class Decorator:INotifier
    {
        protected INotifier _parent;
        protected Admin _admin;
        protected Decorator(INotifier parent,Admin admin) { _parent = parent; _admin = admin; }
        public virtual void Send(string message)
        {
        _parent.Send(message);
        }

    }
}
