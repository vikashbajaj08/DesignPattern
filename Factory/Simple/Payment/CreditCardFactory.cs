using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Simple.Payment;

namespace Factory.Simple.Payment
{
    public class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string CreditCardType)
        {
            switch (CreditCardType)
            {
                case "MoneyBack":
                    return new MoneyBack();
                case "Platinum":
                    return new Platinum();
                default:
                    throw new ArgumentException("Invalid Credit Card");
            }
        }
    }
}
