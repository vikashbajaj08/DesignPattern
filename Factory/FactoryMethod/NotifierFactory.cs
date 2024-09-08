using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.FactoryMethod
{
    public abstract class NotifierFactory
    {
        public abstract INotifier CreateNotifier();
    }
}
