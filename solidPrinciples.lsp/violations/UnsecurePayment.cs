using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrinciples.lsp.violations
{
    public class UnsecurePayment : PaymentBase
    {
        public override void Pay(decimal amount, object customerInfo)
        {
            //unsecure payment operations
        }
    }
}
