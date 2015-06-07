using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrinciples.lsp.better
{
    public interface IVerifiablePayment
    {
        void Verify(object customerInfo);

        void PayWithToken(decimal amount, object customerInfo);
    }
}
