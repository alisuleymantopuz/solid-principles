using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrinciples.lsp.violations
{
    public class PaymentManager
    {
        public void ProcessPayments(List<PaymentBase> paymentModels, object customerInfo)
        {
            paymentModels.ForEach(x =>
                {
                    var payment = x as SecurePayment;
                    if (payment != null)
                        payment.AuthenticationInitialize(customerInfo);

                    x.Pay(12m, customerInfo);
                });
        }
    }
}
