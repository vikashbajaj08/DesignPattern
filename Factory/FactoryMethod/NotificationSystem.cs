using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.FactoryMethod
{
    public class NotificationSystem
    {
        public void Notify(NotifierFactory notifierFactory, string message)
        {
            INotifier notifier = notifierFactory.CreateNotifier();

            notifier.SendNotification(message);
        }
    }
}
