using Factory.FactoryMethod;
using Factory.Simple.Notification;
using Factory.Simple.Payment;
/*Singleton*/
//var logger = Singleton.Logger.Instance;
//logger.Log("Log Information");
/*Simple Factory*/

ICreditCard card = CreditCardFactory.GetCreditCard("MoneyBack");

Console.WriteLine($"Card Type: {card.GetCreditType()} Limit: {card.GetCreditLimit()} Annual Charge: {card.GetAnnualCharge()}");


INotification notification = NotificationFactory.ProcessNotification("SMS");

Console.WriteLine( notification.Send("Hello"));

NotificationSystem notificationSystem = new NotificationSystem();

notificationSystem.Notify(new SMSNotifierFactory(), "Hello");

Console.ReadLine();
