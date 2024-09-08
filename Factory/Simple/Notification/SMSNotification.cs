using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Simple.Notification
{
    public class SMSNotification : INotification
    {
        public string Send(string message) => $"Message has been sent {message}";
    }
}
