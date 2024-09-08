using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.FactoryMethod
{
    public class SMSNotifier : INotifier
    {
        public void SendNotification(string Message)
        {
           Console.WriteLine(Message);
        }
    }
}
