using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Simple.Notification
{
    public class EmailNotification : INotification
    {
        public string Send(string message) => $"Email has been sent: {message}";
    }
}
