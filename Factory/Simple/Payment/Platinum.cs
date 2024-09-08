using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Simple.Payment
{
    public class Platinum : ICreditCard
    {
        public string GetCreditType() => "Platinum Credit Card";

        public int GetCreditLimit() => 3000000;

        public int GetAnnualCharge() => 100;
    }
}
