using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrinciples.lsp.violations
{
    public abstract class PaymentBase
    {
        public abstract void Pay(decimal amount, object customerInfo);
    }
}
