using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Simple.Notification;

namespace Factory.Simple.Notification
{
    public class NotificationFactory
    {
        public static INotification ProcessNotification(string NotificationType)
        {
            switch (NotificationType)
            {
                case "SMS":
                    return new SMSNotification();
                case "Email":
                    return new EmailNotification();
                default:
                    throw new ArgumentException("Invalid Input");
            }
        }
    }
}
