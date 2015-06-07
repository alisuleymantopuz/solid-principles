using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrinciples.lsp.better
{
    public class PaymentManager
    {
        public void ProcessPayments(List<PaymentBase> paymentModels, decimal amount, object customerInfo)
        {
            paymentModels.ForEach(x => x.Pay(amount, customerInfo));
        }

        public void ProcessSecurePayments(List<IVerifiablePayment> paymentModels, decimal amount, object customerInfo)
        {
            paymentModels.ForEach(x => x.PayWithToken(amount, customerInfo));
        }
    }
}
