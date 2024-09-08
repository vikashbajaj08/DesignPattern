using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Simple.Payment
{
    public class MoneyBack : ICreditCard
    {
        public string GetCreditType() => "Money Back Credit Card";

        public int GetCreditLimit() => 2000000;

        public int GetAnnualCharge() => 0;
    }
}
